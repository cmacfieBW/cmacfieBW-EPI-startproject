using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "Sevice Card", GUID = "1d04de50-358a-4331-86ea-b4630fcd9276", Description = "")]
    public class ServiceCardsBlock : BlockData
    {

        [Display(
            Name = "Image",
            Description = "Top image",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual ImageBlock Image { get; set; }

        [Display(Name = "Header", Description = "Header text", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string Header { get; set; }

        [Display(Name = "Description", Description = "Descriptive text", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual XhtmlString Description { get; set; }


        [Display(Name = "Link text", Description = "The text of the of the link", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual string LinkText { get; set; }

        [Display(Name = "Link Url", Description = "The URL of the link", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual Url LinkUrl { get; set; }
    }
}