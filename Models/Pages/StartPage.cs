using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [SiteImageUrl]
    [ContentType(DisplayName = "Start Page", GUID = "875088e0-edd9-4b5c-a993-d5b64770f7c9", Description = "")]
    public class StartPage : BasePageData
    {

        [Display(
            Name = "Logo type",
            Description = "The logotype for the page",
            GroupName = Global.GroupNames.SiteSettings,
            Order = 10)]
        public virtual ContentReference LogoType { get; set; }

        [Display(Name = "Service start page", Description = "Service start page", GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [AllowedTypes(typeof(ServiceStartPage))]
        public virtual PageReference ServiceStartPage { get; set; }

    }
}