﻿using System.Web;
using System.Web.Mvc;

namespace ProvaFrontEnd_07_17
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
