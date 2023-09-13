using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Routing;
using CMS.DocumentEngine.Types.NerdLab;

using Kentico.Content.Web.Mvc;

using nerds_lab.Models;

namespace nerds_lab.ViewComponents
{
    public class HomeItemViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public HomeItemViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            // Initializes instances of required services using dependency injection
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        private string _getRelativePath(HomeItem homeItem)
        {
            // Retrieves the node GUIDs of the selected pages from the 'Pages' property
            List<Guid> selectedPageGuids = homeItem?.Fields.LinkTo
                .Select(i => i.NodeGuid)
                .ToList();

            // Retrieves the pages that correspond to the selected GUIDs
            List<TreeNode> pages = pageRetriever.Retrieve<TreeNode>(query => query
                    .WhereIn("NodeGUID", selectedPageGuids))
                .ToList();

            return pageUrlRetriever.Retrieve(pages.First()).RelativePath;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Gets all pages under the 'HomeItems' node in the content tree
            IEnumerable<HomeItem> homeItems = await pageRetriever.RetrieveAsync<HomeItem>(
                    query => query
                         .Path("/HomeItems", PathTypeEnum.Children)
                         .OrderByAscending("NodeOrder"),
                    cache => cache
                         .Key($"{nameof(HomeItemViewComponent)}|{nameof(InvokeAsync)}|HomeItems")
                         // Flushes the cache when a new navigation item is created or the page order changes
                         .Dependencies((pages, builder) => builder.PagePath("/HomeItems", PathTypeEnum.Children).PageOrder())
                         .Expiration(System.TimeSpan.FromDays(1), useSliding: true));
            
            
            IEnumerable<HomeItemViewModel> homeItemViewModels = homeItems.Select(homeItem => new HomeItemViewModel
            {
                HomeItemTitle = homeItem.Title,
                HomeItemDescription = homeItem.Description,
                HomeItemProgressText = homeItem.ProgressText,
                HomeItemProgressColor = homeItem.ProgressColor,
                HomeItemProgressPercentage = homeItem.ProgressPercentage,
                HomeItemPageLink = _getRelativePath(homeItem)
            });
            
            return View(homeItemViewModels);
        }
    }
}