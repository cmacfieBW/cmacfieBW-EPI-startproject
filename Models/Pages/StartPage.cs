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
            Order = 1)]
        public virtual ImageBlock LogoType { get; set; }

        [Display(Name = "Services", Description = "Services description", GroupName = SystemTabNames.Content, Order = 2)]
        [AllowedTypes(typeof(ServiceStartPage))]
        public virtual PageReference ServicePage { get; set; }

    }
}