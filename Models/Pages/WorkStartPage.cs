using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Work Start Page", GUID = "da02b6e3-ee09-49de-a529-23378899da87", Description = "", GroupName = "StartPage")]
    public class WorkStartPage : BasePageData
    {

        [Display(Name = "Work Content", Description = "Content area for works", GroupName = SystemTabNames.Content, Order = 2)]
        [AllowedTypes(typeof(WorkCardBlock))]
        public virtual ContentArea WorkContentArea { get; set; }
    }
}