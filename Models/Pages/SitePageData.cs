using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "SitePageData", GUID = "0beb3b14-bf87-49d8-b883-f7a2edcb72f2", Description = "")]
    public class SitePageData : PageData
    {
        [Display(GroupName = Global.GroupNames.MetaData, Order = 100)]
        [CultureSpecific]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);
                return !string.IsNullOrWhiteSpace(metaTitle) ? metaTitle : PageName;
            }
            set { this.SetPropertyValue(p => p.MetaTitle, value); }
        }

        [Display(GroupName = Global.GroupNames.MetaData, Order = 200)]
        [CultureSpecific]
        public virtual string[] MetaKeyWords { get; set; }

        [Display(GroupName = Global.GroupNames.MetaData, Order = 300)]
        public virtual string MetaDescription { get; set; }

        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 200)]
        [CultureSpecific]
        public virtual bool HideSiteHeader { get; set; }

        public virtual bool HideSiteFooter { get; set; }

    }
}