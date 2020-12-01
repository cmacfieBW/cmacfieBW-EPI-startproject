using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Service Page", GUID = "37115e77-d490-4e71-b908-9d57b62d23c2", Description = "")]
    public class ServicePage : BasePageData
    {

        [Display(Name = "Intro", Description = "Intro with header and text", GroupName = SystemTabNames.Content, Order = 10)]
        [AllowedTypes(typeof(IntroBlock))]
        public virtual ContentArea IntroContentArea { get; set; }

        [Display(Name = "Sevice Content", Description = "Content area for services", GroupName = SystemTabNames.Content, Order = 20)]
        [AllowedTypes(typeof(ServiceCardsBlock))]
        public virtual ContentArea ServiceContentArea { get; set; }

        [Display(Name = "Work Content", Description = "Content area for works", GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(WorkCardBlock))]
        public virtual ContentArea WorkContentArea { get; set; }

        [Display(Name = "Link button", Description = "Optional Link button for services", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ButtonBlock WorkContentButton { get; set; }

    }
}