using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using static StartProjectGuide.Business.Helpers;

namespace StartProjectGuide.Models.Blocks
{
    [ContentType(DisplayName = "Work Card", GUID = "a3c5bcf1-295d-48aa-b597-fbd760a6777a", Description = "Block with image background, header and a link")]
    public class WorkCardBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "The descriptive text",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentReference Image { get; set; }

        [SelectOne(SelectionFactoryType = typeof(BlockWidthFactory))]
        [Display(Name = "Block width", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual string BlockWidth { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            BlockWidth = Global.BlockWidthFull.Value.ToString();
        }


    }
}