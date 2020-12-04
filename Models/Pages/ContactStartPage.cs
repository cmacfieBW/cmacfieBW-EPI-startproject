using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "ContactStartPage", GUID = "79a48567-518d-4f99-9662-3967799de714", Description = "", GroupName = "Start page")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ContactPage) })]
    public class ContactStartPage : BasePageData
    {

    }
}