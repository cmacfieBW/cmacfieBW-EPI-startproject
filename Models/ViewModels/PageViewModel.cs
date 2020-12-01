using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Models.ViewModels;
using StartProjectGuide.Models.Pages;
using StartProjectGuide.Business.BaseClasses;
using EPiServer;
using EPiServer.Web;
using EPiServer.ServiceLocation;
using System.Web.Mvc;
using EPiServer.Web.Routing;
using StartProjectGuide.Business.Interfaces;

namespace StartProjectGuide.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : BasePageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }

        public IContent Section { get; set; }

        //public LayoutModel Layout
        //{
        //    get
        //    {
        //        ContentReference startPageContentLink = SiteDefinition.Current.StartPage;
        //        IContentLoader contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
        //        var startPage = contentLoader.Get<StartPage>(startPageContentLink);
        //        //var urlResolver = new UrlResolver();
        //        return new LayoutModel
        //        {
        //            HideFooter = startPage.HideSiteFooter,
        //            HideHeader = startPage.HideSiteHeader,
        //            LogoType = startPage.LogoType,
        //            //LogotypeLinkUrl = new MvcHtmlString(_urlResolver.GetUrl(SiteDefinition.Current.StartPage))
        //        };
        //    }
        //}
        //public IContent Section { get; set; }
        //LayoutModel IPageViewModel<T>.Layout
        //{
        //    get
        //    {
        //        ContentReference startPageContentLink = SiteDefinition.Current.StartPage;
        //        IContentLoader contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
        //        var startPage = contentLoader.Get<StartPage>(startPageContentLink);
        //        //var urlResolver = new UrlResolver();
        //        return new LayoutModel
        //        {
        //            HideFooter = startPage.HideSiteFooter,
        //            HideHeader = startPage.HideSiteHeader,
        //            LogoType = startPage.LogoType,
        //            //LogotypeLinkUrl = new MvcHtmlString(_urlResolver.GetUrl(SiteDefinition.Current.StartPage))
        //        };
        //    }
        //    set => throw new NotImplementedException();
        //}
    }
    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T page) where T : BasePageData
        {
            return new PageViewModel<T>(page);
        }
    }
}