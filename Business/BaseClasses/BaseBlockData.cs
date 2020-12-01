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
    /// <summary>
    ///     Base class for all page types
    /// </summary>
    public abstract class BaseBlockData : BlockData
    {
        /// <summary>
        /// Retrieves the current page when "in" this blocks
        /// </summary>
        /// <returns></returns>
        public PageData CurrentPage()
        {
            var pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();
            return pageRouteHelper.Page;
        }
    }
}