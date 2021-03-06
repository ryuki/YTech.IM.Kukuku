﻿using System.Web.Mvc;

namespace YTech.IM.Kukuku.Web.Controllers.CRM
{
    public class CRMAreaRegistration : System.Web.Mvc.AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "CRM";
            }
        }

        public override void RegisterArea(System.Web.Mvc.AreaRegistrationContext context)
        {
            context.MapRoute(
                    "CRM_default",
                    "CRM/{controller}/{action}/{id}",
                    new { action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}
