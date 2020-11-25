using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace StartProjectGuide
{
    public class Global
    {
        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Default", Order = 10)]
            public const string Default = "Default";

            [Display(Name = "MetaData", Order = 20)]
            public const string MetaData = "Meta data";

        }
    }
}