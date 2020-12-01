using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;
using StartProjectGuide.Business.Attributes;

namespace StartProjectGuide.Business.BaseClasses
{
    /// <summary>
    /// Base class for the blocks
    /// </summary>
    public abstract class BaseBlockDataExtended : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [MaxLength(50)]
        [CultureSpecific]
        [AutoPopulateLanguageBranch]
        public virtual string PreHeading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 110)]
        [MaxLength(80)]
        [CultureSpecific]
        [AutoPopulateLanguageBranch]
        public virtual string Heading { get; set; }

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