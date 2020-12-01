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

namespace StartProjectGuide.Business.Extensions
{

    public static class ContentExtensions
    {
        internal static UrlResolver UrlResolver;

        static ContentExtensions()
        {
            UrlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
        }

        /// <summary>
        ///     Returns the external URL for the given page
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="absolute"></param>
        /// <returns></returns>
        public static string GetExternalUrl(this ContentReference reference, bool absolute = false)
        {
            var internalUrl = UrlResolver.GetUrl(reference);
            if (internalUrl == null)
            {
                return string.Empty;
            }
            var url = new UrlBuilder(internalUrl);
            Global.UrlRewriteProvider.ConvertToExternal(url, null, Encoding.UTF8);
            if (absolute)
            {
                var root = SiteDefinition.Current.SiteUrl.ToString();
                if (root.EndsWith("/"))
                {
                    root = root.Substring(0, root.Length - 1);
                }
                return root + url;
            }
            return url.ToString();
        }

        /// <summary>
        ///     Returns page of PageData type for provided content reference.
        /// </summary>
        /// <param name="contentReference">Content reference for which to get page.</param>
        /// <returns>Page of PageData type that match content reference.</returns>
        public static PageData GetPage(this ContentReference contentReference)
        {
            return contentReference.GetPage<PageData>();
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
        ///     Filters content which should not be visible to the user.
        /// </summary>
        public static IEnumerable<T> FilterForDisplay<T>(this IEnumerable<T> contents, bool requirePageTemplate = false)
            where T : IContent
        {
            var accessFilter = new FilterAccess();
            var publishedFilter = new FilterPublished();
            contents = contents.Where(x => !publishedFilter.ShouldFilter(x) && !accessFilter.ShouldFilter(x));
            if (requirePageTemplate)
            {
                var templateFilter = ServiceLocator.Current.GetInstance<FilterTemplate>();
                templateFilter.TemplateTypeCategories = TemplateTypeCategories.Page;
                contents = contents.Where(x => !templateFilter.ShouldFilter(x));
            }
            return contents;
        }

        /// <summary>
        /// Returns all child content as IConent objects
        /// </summary>
        /// <param name="contentReference"></param>
        /// <returns></returns>
        public static IEnumerable<IContent> GetChildrenAsIContent(this ContentReference contentReference)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            try
            {
                return
                    repo.GetChildren<IContent>(contentReference);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Returns if the item has children
        /// </summary>
        /// <param name="contentReference"></param>
        /// <returns></returns>
        public static bool HasChildren(this ContentReference contentReference)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            try
            {
                return
                    repo.GetChildren<IContent>(contentReference).Any();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns if the item has children
        /// </summary>
        /// <param name="contentReference"></param>
        /// <returns></returns>
        public static bool HasChildrenNoCulture(this ContentReference contentReference)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            try
            {
                return
                    repo.GetChildren<IContent>(contentReference, CultureInfo.InvariantCulture).Any();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        ///     Returns all the parent pages of the current page
        /// </summary>
        /// <param name="contentReference"></param>
        /// <returns></returns>
        public static IEnumerable<IContent> GetAncestors(this ContentReference contentReference)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            try
            {
                return
                    repo.GetAncestors(contentReference);
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