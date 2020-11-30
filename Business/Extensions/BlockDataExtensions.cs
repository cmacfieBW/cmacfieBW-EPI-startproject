using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartProjectGuide.Business.Extensions
{
    public static class BlockDataExtensions
    {
        public static string GetViewModelPage(this BlockData block)
        {
            var viewModelName = block.GetOriginalType().Name;
            var folderName = viewModelName;

            // Remove trailing "Block" in order to keep the name "clean"
            if (viewModelName.EndsWith("Block"))
            {
                viewModelName = viewModelName.Substring(0, viewModelName.Length - 5);
            }
            return $"~/Views/Blocks/{folderName}/{viewModelName}.cshtml";
        }
    }
}