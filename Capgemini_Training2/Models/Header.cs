using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capgemini_Training2.Models
{
    public class Header
    {
        public Item HeaderDatasource { get; set; }
        public List<Item> NavigationItems { get; set; }
    }
}