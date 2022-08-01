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
    public class SingleBetBadminton : BaseTest
    {
        IWebDriver Driver;
        
        public SingleBetBadminton (IWebDriver driver)
        {
            Driver = driver;
        } 
        
        IWebElement badmintonIcon => Driver.FindElement(By.Id("Badminton")); 
        //Exapnd markets
        IWebElement expadMarkets => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[11]/i"));
        //Exapnd markets and place a bet in each market
        IWebElement expadMatchResults => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[1]/i"));
        IWebElement matchResultA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[1]/div/div/div[1]/div/span"));
        IWebElement winPointsHighOrLow => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[2]/i"));
         IWebElement winPointsHLA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[2]/div/div/div[2]/div/span"));
        IWebElement correctScore => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[3]/i"));
        IWebElement correctScoreA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[3]/div/div/div[1]/div/span"));
        IWebElement totalPoints => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[4]/i"));
        IWebElement totalPointsB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[4]/div/div/div[2]/div/span"));
        IWebElement longestConsPoints => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[5]/i"));
         IWebElement longestConsPntsA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[5]/div/div/div[1]/div/span"));
        IWebElement firstToScoreA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[6]/i"));
        IWebElement firstToScore17B => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[6]/div/div/div[2]/div/span"));
        IWebElement firstToScoreB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[7]/i"));
        IWebElement firstToScore137A => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[7]/div/div/div[1]/div/span"));
        IWebElement totalPointsOEHL => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[8]/i"));
        IWebElement totPointsOEHLB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[8]/div/div/div[2]/div/span"));
        
        //"Group" of single bet odd selection
       // IWebElement matchResultA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[1]/div/div/div[1]/div/span"));
       // IWebElement winPointsHLB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[2]/div/div/div[2]/div/span"));
        //IWebElement correctScoreA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[3]/div/div/div[1]/div/span"));
       // IWebElement totalPointsB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[4]/div/div/div[2]/div/span"));
        //IWebElement longestConsPntsA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[5]/div/div/div[1]/div/span"));
        //IWebElement firstToScore17B => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[6]/div/div/div[2]/div/span"));
        //IWebElement firstToScore137A => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[7]/div/div/div[1]/div/span"));
        //IWebElement totPointsOEHLB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[8]/div/div/div[2]/div/span"));



        IWebElement firstAvailableDenominator => Driver.FindElement(By.Name("CurrencySymbol"));
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
        public void PlaceSinglebet()
        {
            //add wait line
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
            correctScore.Click();
            Thread.Sleep(2000);
            correctScoreA.Click();
            Thread.Sleep(2000);
            totalPoints.Click();
            Thread.Sleep(2000);
            totalPointsB.Click();
            Thread.Sleep(2000);
            longestConsPoints.Click();
            Thread.Sleep(2000);
            longestConsPntsA.Click();
            Thread.Sleep(2000);
            firstToScoreA.Click();
            Thread.Sleep(2000);
            firstToScore17B.Click();
            Thread.Sleep(2000);
            firstToScoreB.Click();
            Thread.Sleep(2000);
            firstToScore137A.Click();
            Thread.Sleep(2000);
            
           // Thread.Sleep(5000);
           // firstToScore137A.Click();
           // Thread.Sleep(5000);
            totalPointsOEHL.Click();
            Thread.Sleep(5000);
            totPointsOEHLB.Click();
            Thread.Sleep(5000);
            firstAvailableDenominator.Click();
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