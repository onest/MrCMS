﻿using System.Web.Mvc;
using MrCMS.Apps;
using MrCMS.Entities.Multisite;
using MrCMS.Installation;
using MrCMS.Web.Apps.Articles.Areas.Admin.Controllers;
using NHibernate;
using Ninject;

namespace MrCMS.Web.Apps.Articles
{
    public class ArticlesApp : MrCMSApp
    {
        public override string AppName
        {
            get { return "Articles"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        protected override void RegisterServices(IKernel kernel)
        {
            
        }

        protected override void OnInstallation(ISession session, InstallModel model, Site site)
        {
        }

        protected override void RegisterApp(MrCMSAppRegistrationContext context)
        {
            context.MapAreaRoute("Article Admin controllers", "Admin", "Admin/Apps/Articles/{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional},
                new[] {typeof (AuthorInfoController).Namespace});

        }
    }
}