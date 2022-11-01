using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc.Presentation;
using Capgemini_Training2.Models;
using Sitecore.Web.UI.WebControls;
using Sitecore.Data.Fields;

namespace Capgemini_Training2.Controllers
{
    public class Carousel2Controller : Controller
    {
        // GET: Carousel2
        public ActionResult Index()
        {
            var datasource = RenderingContext.Current.Rendering.Item;
            var image1 = new MvcHtmlString(FieldRenderer.Render(datasource, "Image1"));
            var image2 = new MvcHtmlString(FieldRenderer.Render(datasource, "Image2"));
            var image3 = new MvcHtmlString(FieldRenderer.Render(datasource, "Image3"));
            var next = new MvcHtmlString(FieldRenderer.Render(datasource, "Next"));
            var prev = new MvcHtmlString(FieldRenderer.Render(datasource, "Prev"));
            MultilistField slidelist = datasource.Fields["Slides_2"];
            var slideitems = slidelist.GetItems();
            List<Slides_2> slides2 = new List<Slides_2>();
            foreach (var slide in slideitems)
            {
                slides2.Add(new Slides_2
                {
                    Text = new MvcHtmlString(FieldRenderer.Render(slide, "Text")),
                    Description = new MvcHtmlString(FieldRenderer.Render(slide, "Description")),
                    Image = new MvcHtmlString(FieldRenderer.Render(slide, "Image")),

                });
            }

            return View("~/Views/Carousel_2.cshtml", new Carousel_2
            {
                Image1 = image1,
                Image2 = image2,
                Image3 = image3,
                Next = next,
                Prev = prev,
                Slides2 = slides2
            });
        }
    }
}