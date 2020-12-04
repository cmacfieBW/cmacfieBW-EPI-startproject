using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Filters;
using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;
using StartProjectGuide.Business.Attributes;
using StartProjectGuide.Business.BaseClasses;

namespace StartProjectGuide.Business
{

    public static class ContentExtensions
    {
        /// <summary>
        ///     Shorthand for DataFactory.Instance.Get
        /// </summary>
        /// <typeparam name="TContent"></typeparam>
        /// <param name="contentLink"></param>
        /// <returns></returns>
        public static TContent Get<TContent>(this ContentReference contentLink) where TContent : IContent
        {
            return DataFactory.Instance.Get<TContent>(contentLink);
        }

        /// <summary>
        ///     Returns page of concrete type for provided content reference.
        /// </summary>
        /// <typeparam name="T">Type of page (PageData).</typeparam>
        /// <param name="contentReference">Content reference for which to get page.</param>
        /// <returns>Page of <typeparamref name="T" /> that match content reference.</returns>
        public static T GetPage<T>(this ContentReference contentReference) where T : PageData
        {
            if (contentReference.IsNullOrEmpty())
            {
                return null;
            }

            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            return loader.Get<PageData>(contentReference) as T;
        }

        /// <summary>
        ///     Indicates whether the specified content reference is null or an EmptyReference.
        /// </summary>
        /// <param name="contentReference">Content reference to test.</param>
        /// <returns>true if content reference is null or EmptyReference else false</returns>
        public static bool IsNullOrEmpty(this ContentReference contentReference)
        {
            return ContentReference.IsNullOrEmpty(contentReference);
        }

        /// <summary>
        ///     Returns all the childpages of the current page
        /// </summary>
        /// <param name="contentReference"></param>
        /// <returns></returns>
        public static IEnumerable<PageData> GetChildren(this ContentReference contentReference)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            try
            {
                return
                    repo.GetChildren<PageData>(contentReference);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///     Returns all the childpages of the current page
        /// </summary>
        /// <param name="contentReference"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetChildren<T>(this ContentReference contentReference) where T : IContent
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            try
            {
                return
                    repo.GetChildren<T>(contentReference);
            }
            catch
            {
                return null;
            }
        }
    }
}