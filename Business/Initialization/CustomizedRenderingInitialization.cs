using System;
using EPiServer.Framework.Initialization;
using EPiServer.Framework;
using StartProjectGuide.Business.Rendering;
using System.Web.Mvc;
using EPiServer.Web;

namespace StartProjectGuide.Business.Initialization
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class CustomizedRenderingInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            ViewEngines.Engines.Insert(0, new SiteViewEngine());
            context.Locate.TemplateResolver().TemplateResolved += TemplateCoordinator.OnTemplateResolved;
        }

        public void Uninitialize(InitializationEngine context)
        {
            throw new NotImplementedException();
        }
    }
}