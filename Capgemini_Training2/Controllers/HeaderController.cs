using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capgemini_Training2.Models;
using Sitecore.Data.Items;

namespace Capgemini_Training2.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Header
        public ActionResult Index()
        {
            //Header model = new Header();
            List<Item> navigationItems = new List<Item>();

            //model.HeaderDatasource = RenderingContext.Current.Rendering.Item;
            var homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
            if(homeItem!=null)
            {
                navigationItems.Add(homeItem);
            }
            if (homeItem?.Children!= null)
            {
                foreach (Item child in homeItem.Children)
                    navigationItems.Add(child);

            }

                return View("~/Views/Component/Header.cshtml",new Header
                {
                    HeaderDatasource = RenderingContext.Current.Rendering.Item,
                    NavigationItems=navigationItems
                });
        }
    }
}