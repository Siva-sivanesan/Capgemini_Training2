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
    public class BasicController : Controller
    {
        // GET: Basic
        public ActionResult Index()
        {
            var datasource = RenderingContext.Current.Rendering.Item;
            var text = new MvcHtmlString(FieldRenderer.Render(datasource, "Text"));
            var description = new MvcHtmlString(FieldRenderer.Render(datasource, "Description"));
            var next = new MvcHtmlString(FieldRenderer.Render(datasource, "Next"));
            var previous = new MvcHtmlString(FieldRenderer.Render(datasource, "Previous"));

            var slideCountParameter = RenderingContext.Current.Rendering.Parameters["SlideCount"];
            int.TryParse(slideCountParameter, out int result);
            
            MultilistField slidelist = datasource.Fields["Slides"];
            
           var slideitems = slidelist.GetItems();
            int slideCount = result == 0 ? slideitems.Count() : result;
            List<Slides> slides = new List<Slides>();
            foreach (var slide in slideitems.Take(slideCount))
            {
                slides.Add(new Slides
                {
                    Carousel_Text = new MvcHtmlString(FieldRenderer.Render(slide, "Carousel Text")),
                    Carousel_Description = new MvcHtmlString(FieldRenderer.Render(slide, "Carousel Description")),
                    Image1 = new MvcHtmlString(FieldRenderer.Render(slide, "Image1")),
                    
                });
            }

            return View("~/Views/Carousel.cshtml",new Basic {
				Text = text,
				Description = description,
				Next = next,
				Previous = previous,
				slide = slides
			});
        }
    }
}