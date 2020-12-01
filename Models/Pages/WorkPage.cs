using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Work Page", GUID = "ab2b6e28-0d00-438e-a7fd-bec8721123c6", Description = "")]
    public class WorkPage : BasePageData
    {
        [Display(Name = "Header", Order = 1)]
        public virtual string Header { get; set; }

        [Display(Name = "Work Content", Description = "Content area for works", GroupName = SystemTabNames.Content, Order = 2)]
        [AllowedTypes(typeof(WorkCardBlock))]
        public virtual ContentArea WorkContentArea { get; set; }
    }
}