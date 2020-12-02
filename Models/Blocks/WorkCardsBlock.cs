using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "Work cards wrapper", GUID = "0f82f6ba-15bb-4441-af36-5fd21f7b379b", Description = "")]
    public class WorkCardsBlock : BlockData
    {

        [Display(Name = "Work cards", Description = "Content area for work cards", GroupName = SystemTabNames.Content, Order = 20)]
        [AllowedTypes(typeof(WorkCardBlock))]
        public virtual ContentArea WorkContentArea { get; set; }


        [Display(Name = "Link button", Description = "Optional Link button for services", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ButtonBlock WorkContentButton { get; set; }
    }
}