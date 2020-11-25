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
        public virtual string Text { get; set; }

        [Display(
            Name = "TextLength",
            Description = "The ",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual int? TextLength
        {
            get
            {
                if(Text != null)
                {
                    return CalculateTextLength(Text);
                }
                return null;
            }
        }

        private static int CalculateTextLength (string text)
        {
            return text.Length;
        }

    }
}