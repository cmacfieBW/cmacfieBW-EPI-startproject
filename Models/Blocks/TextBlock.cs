using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "TextBlock", GUID = "7f9ac117-cb2e-456d-aef9-15f754c71540", Description = "")]
    public class TextBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Body { get; set; }

    }
}