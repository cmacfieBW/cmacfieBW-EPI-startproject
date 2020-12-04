using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;
using static StartProjectGuide.Business.Helpers;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Work Page", GUID = "ab2b6e28-0d00-438e-a7fd-bec8721123c6", Description = "", GroupName = "Sub page")]
    public class WorkPage : BasePageData
    {

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ImageBlock Image { get; set; }

        [Display(Name = "Content Area", Description = "Main Content Area", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual ContentArea MainContentArea { get; set; }

        /** Teaser */
        [Display(Name = "Description", Description = "Descriptive text", GroupName = Global.GroupNames.Teaser, Order = 1)]
        public virtual XhtmlString TeaserDescription { get; set; }

    }
}