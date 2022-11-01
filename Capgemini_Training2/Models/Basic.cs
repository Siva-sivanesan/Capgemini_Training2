using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capgemini_Training2.Models
{
    public class Basic
    { public MvcHtmlString Text { get; set; }
        public MvcHtmlString Description { get; set; }
        public MvcHtmlString Next { get; set; }
        public MvcHtmlString Previous { get; set; }

        public List<Slides> slide { get; set; }
    }

        public class Slides
    {
        public MvcHtmlString Carousel_Text { get; set; }
        public MvcHtmlString Carousel_Description { get; set; }
        public MvcHtmlString Image1 { get; set; }
        
    }
    }
