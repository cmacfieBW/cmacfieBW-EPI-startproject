using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Pages;
using StartProjectGuide.Models.ViewModels;

namespace StartProjectGuide.Controllers
{
    public class BlogPageController : PageControllerBase<BlogPage>
    {
        public ViewResult Index(BlogPage currentPage)
        { 
            var model = CreateModel(currentPage);
            return View("~/Views/BlogPage/Index.cshtml", model);
        }
        public static IPageViewModel<BlogPage> CreateModel(BlogPage page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<BlogPage>;
        }
    }
}