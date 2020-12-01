using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace StartProjectGuide
{
    public class Global : EPiServer.Global
    {
        public readonly static SelectItem BlockWidthFull = new SelectItem() { Text = "Full", Value = "span12" };
        public readonly static SelectItem BlockWidthHalf = new SelectItem() { Text = "Half", Value = "span6" };
        public readonly static SelectItem BlockWidthQuarter = new SelectItem() { Text = "Quater", Value = "span3" };

        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Default", Order = 10)]
            public const string Default = "Default";

            [Display(Name = "Meta Data", Order = 20)]
            public const string MetaData = "Meta Data";

            [Display(Name = "Site Settings", Order = 30)]
            public const string SiteSettings = "Site Settings";


        }

        public static IList<SelectItem> BlockWidths
        {
            get
            {
                SelectItem[] Items = new SelectItem[3];
                Items[0] = BlockWidthFull;
                Items[1] = BlockWidthHalf;
                Items[2] = BlockWidthQuarter;
                return Items;

            }
        }
    }
}
