﻿using System.Web;
using System.Web.Mvc;

namespace Lab29_WebAPI_MovieDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
