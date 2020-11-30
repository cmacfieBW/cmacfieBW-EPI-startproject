using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "CarouselleBlock", GUID = "11473fb8-b3f4-4678-ac48-10a29bddaf62", Description = "")]
    public class CarouselleBlock : BlockData
    {
        [AllowedTypes(typeof(ImageItemHorizontalBlock))]
        public virtual ContentArea CarouselleItems { get; set; }

    }
}