using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "ImageTextBlocks wrapper", GUID = "610ee9ee-4887-430e-a3b7-aa0ce97c7e79", Description = "")]
    public class ImageTextBlockWrapperBlock : BlockData
    {

        [AllowedTypes(typeof(ImageTextBlock))]
        [Display(
            Name = "Image text block wrapper",
            Description = "Holds image text blocks",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea Content { get; set; }

    }
}