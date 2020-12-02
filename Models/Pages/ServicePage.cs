﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Service cards wrapper", GUID = "37115e77-d490-4e71-b908-9d57b62d23c2", Description = "")]
    public class ServicePage : BasePageData
    {
        [Display(
            Name = "Image",
            Description = "Top image",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual ImageBlock Image { get; set; }

        [Display(Name = "Content Area", Description = "Main Content Area", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual ContentArea MainContentArea { get; set; }

        /** Teaser */
        [Display(Name = "Description", Description = "Descriptive text", GroupName = Global.GroupNames.Teaser, Order = 1)]
        public virtual XhtmlString TeaserDescription { get; set; }

        [Display(Name = "Link Url", Description = "The URL of the link", GroupName = Global.GroupNames.Teaser, Order = 2)]
        public virtual Url TeaserLinkUrl { get; set; }

    }
}