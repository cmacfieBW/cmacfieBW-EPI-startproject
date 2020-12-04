using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Personalization;
using EPiServer.ServiceLocation;
using EPiServer.SpecializedProperties;
using EPiServer.Web.Routing;

namespace StartProjectGuide.Business.BaseClasses
{
    public abstract class BaseBlockData : BlockData
    {
        public PageData CurrentPage()
        {
            var pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();
            return pageRouteHelper.Page;
        }
    }
}