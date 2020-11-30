using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Controllers;
using StartProjectGuide.Models.Pages;

namespace StartProjectGuide.Business.Rendering
{
    [ServiceConfiguration(typeof(IViewTemplateModelRegistrator))]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public const string BlockFolder = "~/Views/Shared/Blocks/";
        public const string PagePartialsFolder = "~/Views/Shared/PagePartials/";

        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            //viewTemplateModelRegistrator.Add(typeof(BasePageData), new TemplateModel { Name = "Type1", AvailableWithoutTag = true, Path = BlockPath("TextBlock.cshtml") });
            //viewTemplateModelRegistrator.Add(typeof(BasePageData), new TemplateModel { Name = "Type2", AvailableWithoutTag = true, Path = BlockPath("LogoBlock.cshtml") });
            //viewTemplateModelRegistrator.Add(typeof(BasePageData), new TemplateModel { Name = "Type3", AvailableWithoutTag = true, Path = BlockPath("ButtonBlock.cshtml") });
        }
        public static void OnTemplateResolved(object sender, TemplateResolverEventArgs args)
        {
            //Disable DefaultPageController for page types that shouldn't have any renderer as pages
            if (args.ItemToRender is IContainerPage && args.SelectedTemplate != null && args.SelectedTemplate.TemplateType == typeof(DefaultPageController))
            {
                args.SelectedTemplate = null;
            }
        }
        private static string BlockPath(string fileName)
        {
            return string.Format("{0}{1}", BlockFolder, fileName);
        }

        private static string PagePartialPath(string fileName)
        {
            return string.Format("{0}{1}", PagePartialsFolder, fileName);
        }
    }
}