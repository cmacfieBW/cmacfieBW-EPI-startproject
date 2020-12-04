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
    [ContentType(DisplayName = "Start Page", GUID = "875088e0-edd9-4b5c-a993-d5b64770f7c9", Description = "", GroupName = "Start Page")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ServiceStartPage), typeof(WorkStartPage), typeof(ContactStartPage), typeof(StandardPage), typeof(LandingPage), typeof(ContentFolder) }, // Pages we can create under the start page...
        ExcludeOn = new[] { typeof(ServiceStartPage), typeof(WorkStartPage), typeof(ContactStartPage), typeof(StandardPage), typeof(LandingPage) })] // ...and underneath those we can't create additional start pages

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

        [Display(Name = "Work start page", Description = "Work start page", GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [AllowedTypes(typeof(WorkStartPage))]
        public virtual PageReference WorkStartPage { get; set; }

        [Display(Name = "Contact start page", Description = "Contact start page", GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [AllowedTypes(typeof(ContactStartPage))]
        public virtual PageReference ContactPage { get; set; }

        [Display(Name = "Content", Description = "Main body content", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ContentArea MainBodyContent { get; set; }


    }
}