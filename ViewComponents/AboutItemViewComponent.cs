using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using CMS.DataEngine;
using Microsoft.AspNetCore.Mvc;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Routing;
using CMS.DocumentEngine.Types.NerdLab;
using CMS.MediaLibrary;
using Kentico.Content.Web.Mvc;
using nerds_lab.Models;

namespace nerds_lab.ViewComponents
{
    public class AboutItemViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IMediaFileUrlRetriever  mediaFileUrlRetriever;

        public AboutItemViewComponent(IPageRetriever pageRetriever, IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            // Initializes instances of required services using dependency injection
            this.pageRetriever = pageRetriever;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }
        
        private string _getMediaUrl(AboutItem aboutItem)
        {
            MediaFileInfo assetToMediaFileInfo =
                new ObjectQuery<MediaFileInfo>().ForAssets(aboutItem.Fields.Image).GetEnumerableTypedResult().First();
            return mediaFileUrlRetriever.Retrieve(assetToMediaFileInfo).RelativePath;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Gets all pages under the 'HomeItems' node in the content tree
            IEnumerable<AboutItem> aboutItems = await pageRetriever.RetrieveAsync<AboutItem>(
                query => query
                    .Path("/AboutPage", PathTypeEnum.Children)
                    .OrderByAscending("NodeOrder"),
                cache => cache
                    .Key($"{nameof(AboutItemViewComponent)}|{nameof(InvokeAsync)}|AboutPage")
                    // Flushes the cache when a new navigation item is created or the page order changes
                    .Dependencies(
                        (pages, builder) => builder.PagePath("/AboutPage", PathTypeEnum.Children).PageOrder())
                    .Expiration(System.TimeSpan.FromDays(1), useSliding: true));


            IEnumerable<AboutItemViewModel> aboutItemViewModel = aboutItems.Select(aboutItem =>
                new AboutItemViewModel
                {
                    Name = aboutItem.Name,
                    Designation = aboutItem.Designation,
                    Image = _getMediaUrl(aboutItem),
                    Quote = aboutItem.Quote,
                });

            return View(aboutItemViewModel);
        }
    }
}