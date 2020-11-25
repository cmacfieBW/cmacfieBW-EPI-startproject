//using System;
//using System.ComponentModel.DataAnnotations;
//using EPiServer.Core;
//using EPiServer.DataAbstraction;
//using EPiServer.DataAnnotations;
//using EPiServer.SpecializedProperties;
//using StartProjectGuide.Models.ViewModels;
//using StartProjectGuide.Models.Pages;

//namespace StartProjectGuide.Models.ViewModels
//{
//    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
//    {
//        public PageViewModel(T currentPage)
//        {
//            CurrentPage = currentPage;
//        }

//        public T CurrentPage { get; private set; }

//        public LayoutModel Layout { get; set; }
//        public IContent Section { get; set; }

//    }
//    public static class PageViewModel
//    {
//        public static PageViewModel<T> Create<T>(T page) where T : SitePageData
//        {
//            return new PageViewModel<T>(page);
//        }
//    }
//}