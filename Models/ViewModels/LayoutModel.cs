using EPiServer.Web;
using StartProjectGuide.Models.Blocks;
using System.Web;
using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Core;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Pages;

namespace StartProjectGuide.Models.ViewModels
{
    public class LayoutModel
    {
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }

        public ImageBlock LogoType { get; set; }
    }

}
