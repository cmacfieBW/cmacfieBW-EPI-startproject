﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using StartProjectGuide.Business.BaseClasses;
using StartProjectGuide.Models.Blocks;

namespace StartProjectGuide.Models.Pages
{
    [ContentType(DisplayName = "Service Start Page", GUID = "ea5410ce-697e-46b5-813a-5024bbec05f3", Description = "", GroupName = "StartPage")]
    public class ServiceStartPage : BasePageData
    {


        //[Display(Name = "Content", GroupName = SystemTabNames.Content, Order = 20)]
        //[AllowedTypes(typeof(IntroBlock), typeof(ServiceCardsBlock), typeof(WorkCardsBlock))]
        //public virtual PageReference ServicePage { get; set; }

    }
}