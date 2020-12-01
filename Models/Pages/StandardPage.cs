using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Standard Page", GUID = "b110e7ba-a846-4215-b0ae-6ecd89f55e13", Description = "")]
    public class StandardPage : BasePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The page heading",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}