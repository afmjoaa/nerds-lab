using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Routing;
using CMS.DocumentEngine.Types.NerdLab;

using Kentico.Content.Web.Mvc;

using nerds_lab.Models;

namespace nerds_lab.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public NavigationMenuViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            // Initializes instances of required services using dependency injection
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Gets all pages under the 'Navigation' node in the content tree
            IEnumerable<NavigationItem> navigationPages = await pageRetriever.RetrieveAsync<NavigationItem>(
                    query => query
                         .Path("/Navigation", PathTypeEnum.Children)
                         .OrderByAscending("NodeOrder"),
                    cache => cache
                         .Key($"{nameof(NavigationMenuViewComponent)}|{nameof(InvokeAsync)}|navigationpages")
                         // Flushes the cache when a new navigation item is created or the page order changes
                         .Dependencies((pages, builder) => builder.PagePath("/Navigation", PathTypeEnum.Children).PageOrder())
                         .Expiration(System.TimeSpan.FromDays(1), useSliding: true));

            // Gets all pages referenced by the retrieved navigation items
            IEnumerable<TreeNode> linkToPages = await pageRetriever.RetrieveAsync<TreeNode>(
                    query => query
                         .WhereIn("NodeGUID", navigationPages.Select(i => i.Fields.LinkTo.First().NodeGuid).ToList())
                         .WithPageUrlPaths()
                         .GetEnumerableTypedResult(),
                    cache => cache
                         .Key($"{nameof(NavigationMenuViewComponent)}|{nameof(InvokeAsync)}|linkToPages")
                         // Flushes the cache when the page data changes (could contain a URL slug update)
                         .Dependencies((pages, builder) => builder.Pages(pages).PagePath("/Navigation"))
                         .Expiration(System.TimeSpan.FromDays(1), useSliding: true)) ;

            // Matches both collections on 'NodeGUID,' ensuring order from the first collection
            IEnumerable<NavigationItemViewModel> menuItems = navigationPages.Join(
                         linkToPages,
                         c1 => c1.Fields.LinkTo.First().NodeGuid,
                         c2 => c2.NodeGUID,
                         (c1, c2) => new NavigationItemViewModel
                         {
                               MenuItemRelativeUrl = pageUrlRetriever.Retrieve(c2).RelativePath,
                             MenuItemText = c1.DocumentName
                         });

            return View(menuItems);
        }
    }
}