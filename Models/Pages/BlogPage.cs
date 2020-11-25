using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Non-default page", GUID = "b8da3d1b-1cd6-4016-b4c4-092ba7410892", Description = "A non-default page")]
    public class BlogPage : BasePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Blog entry",
            Description = "A text block for the blog entry",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString BlogEntry { get; set; }

    }
}