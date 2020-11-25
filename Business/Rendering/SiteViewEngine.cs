using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace StartProjectGuide.Business.Rendering
{
    public class SiteViewEngine : RazorViewEngine
    {
        private static readonly string[] AdditionalPartialViewFormats = new[]
        {
            TemplateCoordinator.BlockFolder + "{0}.cshtml",
            TemplateCoordinator.PagePartialsFolder + "{0}.cshtml"
        };


        public SiteViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(AdditionalPartialViewFormats).ToArray();
        }
    }

}