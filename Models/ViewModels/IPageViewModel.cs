//using System;
//using System.ComponentModel.DataAnnotations;
//using EPiServer.Core;
//using EPiServer.DataAbstraction;
//using EPiServer.DataAnnotations;
//using EPiServer.SpecializedProperties;
//using StartProjectGuide.Models.Pages;

//namespace StartProjectGuide.Models.ViewModels
//{
//    public interface IPageViewModel<out T> where T : SitePageData
//    {
//        T CurrentPage { get; }
//        LayoutModel Layout { get; set; }

//        IContent Section { get; set; }
//    }
//}