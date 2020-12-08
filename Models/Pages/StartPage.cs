﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Web;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [SiteImageUrl]
    [ContentType(DisplayName = "Start Page", GUID = "875088e0-edd9-4b5c-a993-d5b64770f7c9", Description = "Root type of page for the website", GroupName = Global.PageTypes.SpecialPage)]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ServiceLandingPage), typeof(WorkLandingPage), typeof(ContactLandingPage), typeof(StandardPage), typeof(LandingPage), typeof(ContentFolder) }, // Pages we can create under the start page...
        ExcludeOn = new[] { typeof(ServiceLandingPage), typeof(WorkLandingPage), typeof(ContactLandingPage), typeof(StandardPage), typeof(LandingPage) })] // ...and underneath those we can't create additional start pages

    public class StartPage : BasePageData
    {
        [Display(Name = "Service start page", Description = "Service start page", GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [AllowedTypes(typeof(ServiceLandingPage))]
        public virtual PageReference ServiceStartPage { get; set; }

        [Display(Name = "Work start page", Description = "Work start page", GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [AllowedTypes(typeof(WorkLandingPage))]
        public virtual PageReference WorkStartPage { get; set; }

        [Display(Name = "Contact start page", Description = "Contact start page", GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [AllowedTypes(typeof(ContactLandingPage))]
        public virtual PageReference ContactPage { get; set; }

        [Display(Name = "Content", Description = "Main body content", GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(WorksPreviewBlock), typeof(ImageTextBlock), typeof(ColorTextBlock), typeof(TextBlock))]
        public virtual ContentArea MainBodyContent { get; set; }

        [Display(Name = "Facebook link", GroupName = Global.GroupNames.SocialMedia, Order = 10)]
        public virtual Url FacebookLink { get; set; }

        [Display(Name = "Twitter link", GroupName = Global.GroupNames.SocialMedia, Order = 10)]
        public virtual Url TwitterLink { get; set; }

        [Display(Name = "LinkedIn link", GroupName = Global.GroupNames.SocialMedia, Order = 10)]
        public virtual Url LinkedInLink { get; set; }

        [Display(Name = "Instagram link", GroupName = Global.GroupNames.SocialMedia, Order = 10)]
        public virtual Url InstagramLink { get; set; }


    }
}