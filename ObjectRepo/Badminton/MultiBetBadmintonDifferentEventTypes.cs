using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;
using NUnit.Framework;

//extent report imports
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace AutomationBetMan.ObjectRepo.FootballObjects.Single 
{
    public class MultiBetBadmintonDifferentEventTypes : BaseTest
    {
        IWebDriver Driver;
        
        public MultiBetBadmintonDifferentEventTypes (IWebDriver driver)
        {
            Driver = driver;
        } 
        
        //Badminton Objects
        IWebElement badmintonIcon => Driver.FindElement(By.Id("Badminton")); 
        //Exapnd markets
        IWebElement expadMarkets => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[11]/i"));
        //Exapnd markets and place a bet in each market
        IWebElement expadMatchResults => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[1]/i"));
        IWebElement matchResultA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[1]/div/div/div[1]/div/span"));
        IWebElement winPointsHighOrLow => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[2]/i"));
        IWebElement winPointsHLA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[2]/div/div/div[2]/div/span"));
  
        //Football Objects
        IWebElement footballGroupIcon => Driver.FindElement(By.Id("FootballGroup")); 
        IWebElement spanishSingleMatch => Driver.FindElement(By.Id("SpanishFastLeagueFootballSingleMatch"));

        //"Group" of single bet odd selection
        IWebElement xMROdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div/span"));
      

        //Betslip objects
        IWebElement manualStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[2]/div[3]/div/div/div[2]/i"));
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));

        //Group of Multiple bet odds
        IWebElement homeHTOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[3]/div/div[1]/div/span"));
        IWebElement xHTOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[3]/div/div[2]/div/span"));
        IWebElement awayHTOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[3]/div/div[3]/div/span"));

        //Global for waiting for presence of an element
        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //wait.Until(ExpectedConditions.ElementIsVisible(By.IdentifierHere("_______________")));

        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //wait.Until(driver => Password.Displayed);
        
        //Functions
        public void PlaceMultiBet()
        {
            //For Badminton
            Thread.Sleep(2000);
            badmintonIcon.Click();
            Thread.Sleep(2000);
            badmintonIcon.Click();
            Thread.Sleep(2000);
            expadMarkets.Click();
            Thread.Sleep(2000);
            expadMatchResults.Click();
            Thread.Sleep(2000);
            matchResultA.Click();
            Thread.Sleep(2000);
            winPointsHighOrLow.Click();
            Thread.Sleep(2000);
            winPointsHLA.Click();
            Thread.Sleep(2000);
            //For football
            Thread.Sleep(10000);
            footballGroupIcon.Click();
            Thread.Sleep(10000);
            spanishSingleMatch.Click();
            Thread.Sleep(10000);
            xMROdd.Click();
            for (int i=1; i<=20; i++) {
            manualStakeEdit.Click();
            }
            Thread.Sleep(10000);
            submitBetSlip.Click();

            //manualStakeEdit.Click();
            Thread.Sleep(5000);
            submitBetSlip.Click();

          /*  try{

                Assert.AreEqual("Bet successfully placed!", driver.FindElement(By.ClassName("SuccessMessage")));

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
            */
        }
        
/*        public void PlaceMultiplebet()
        {
            //add wait line
            Thread.Sleep(10000);
            badmintonIcon.Click();
            Thread.Sleep(10000);
            badmintonIcon.Click();
            Thread.Sleep(10000);
            homeHTOdd.Click();
            Thread.Sleep(10000);
            xHTOdd.Click();
            Thread.Sleep(10000);
            awayHTOdd.Click();
            Thread.Sleep(10000);
            submitBetSlip.Click();
        }*/
    }
}