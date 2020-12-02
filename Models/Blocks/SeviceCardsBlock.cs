using System;
using System.Collections.Generic;
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

        [Display(Name = "Sevice cards", Description = "Content area for service cards", GroupName = SystemTabNames.Content, Order = 20)]
        [AllowedTypes(typeof(ServiceCardBlock))]
        public virtual ContentArea ServiceContentArea { get; set; }

    }
}