using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capgemini_Training2.Models
{
    public class Carousel_2
    {
        public MvcHtmlString Image1 { get; set; }
        public MvcHtmlString Image2 { get; set; }
        public MvcHtmlString Image3 { get; set; }
        public MvcHtmlString Next { get; set; }
        public MvcHtmlString Prev { get; set; }

        public List<Slides_2> Slides2 { get; set; }
    }

    public class Slides_2
    {
        public MvcHtmlString Text { get; set; }
        public MvcHtmlString Description { get; set; }
        public MvcHtmlString Image { get; set; }

    }
}