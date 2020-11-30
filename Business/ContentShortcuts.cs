using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using StartProjectGuide.Models.Pages;

namespace StartProjectGuide.Business
{
    public static class ContentShortcuts
    {
       
        public static StartPage GetStartPage()
        {
            if(ContentReference.StartPage != null)
            {
                PageReference startPageReference = ContentReference.StartPage;
                StartPage startPage = DataFactory.Instance.Get<StartPage>(startPageReference) as StartPage;
                return startPage;
            } else
            {
                PageReference reference = ContentReference.StartPage;
                StartPage startPage = DataFactory.Instance.Get<StartPage>(reference) as StartPage;
                return startPage;
            }
        }
    }
}