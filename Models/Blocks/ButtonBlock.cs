using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "Button", GUID = "c3e5c375-c4ec-402c-8707-f7c1824d134c", Description = "")]
    public class ButtonBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "The text of the button",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Text { get; set; }

        [Display(
            Name = "URL",
            Description = "The url that the button leads to",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual Url Url { get; set; }

    }
}