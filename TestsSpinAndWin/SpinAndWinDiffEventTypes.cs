using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using SeleniumCSharpNetCore.Pages;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Reflection;
using AutomationBetMan.BaseClass;
using AutomationBetMan.ObjectRepo.FootballObjects.Single;
using System.Threading;

namespace AutomationBetMan.ObjectRepo
{
    [TestFixture]
    public class SpinAndinDiffEventTypes : BaseTest
    {
        [Test]
        public void SpinAndWinDiffGames()
        {
            var allMarketsBets = new SpinAndWinAll(driver);
            allMarketsBets.PlaceSinglebetsSW();

            Thread.Sleep(2000);
        }
    }
}
