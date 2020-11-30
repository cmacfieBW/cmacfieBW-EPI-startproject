using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Pages;

namespace StartProjectGuide.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : BasePageData
    {
        T CurrentPage { get; }
        IContent Section { get; set; }

        LayoutModel Layout { get; set; }
    }
}