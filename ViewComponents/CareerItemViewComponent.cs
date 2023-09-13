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
    public class CareerItemViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public CareerItemViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            // Initializes instances of required services using dependency injection
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Gets all pages under the 'HomeItems' node in the content tree
            IEnumerable<CareerItem> careerItem = await pageRetriever.RetrieveAsync<CareerItem>(
                query => query
                    .Path("/CareerPage", PathTypeEnum.Children)
                    .OrderByAscending("NodeOrder"),
                cache => cache
                    .Key($"{nameof(CareerItemViewComponent)}|{nameof(InvokeAsync)}|CareerPage")
                    // Flushes the cache when a new navigation item is created or the page order changes
                    .Dependencies(
                        (pages, builder) => builder.PagePath("/CareerPage", PathTypeEnum.Children).PageOrder())
                    .Expiration(System.TimeSpan.FromDays(1), useSliding: true));


            IEnumerable<CareerItemViewModel> careerItemViewModel = careerItem.Select(careerItem =>
                new CareerItemViewModel
                {
                    CareerItemTitle = careerItem.Title,
                    CareerItemDescription = careerItem.Description,
                    CareerItemRibbonColor = careerItem.RibbonColor,
                    CareerItemResponsibility = careerItem.Responsibility,
                    CareerItemTechStack = careerItem.TechStack,
                    CareerItemProject = careerItem.Project,
                    CareerItemExperience = careerItem.Experience,
                    CareerItemLocation = careerItem.Location,
                    CareerItemCompensation = careerItem.Compensation,
                    CareerItemApplyText = careerItem.ApplyText,
                });

            return View(careerItemViewModel);
        }
    }
}