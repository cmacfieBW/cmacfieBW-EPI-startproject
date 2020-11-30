using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using StartProjectGuide.Business.Extensions;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Controllers
{
    public class ImageTextBlockWrapperBlockController : BlockController<ImageTextBlockWrapperBlock>
    {
        public override ActionResult Index(ImageTextBlockWrapperBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
