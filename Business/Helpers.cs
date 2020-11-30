using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;

namespace StartProjectGuide.Business
{

    public static class Helpers
    {

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

        public class BlockWidthFactory : ISelectionFactory
        {
            public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
            {
                return Global.BlockWidths;
            }
        }
    }
}