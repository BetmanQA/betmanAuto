using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;


namespace AutomationBetMan.ObjectRepo

{
    public class BetslipObjects : BaseTest
    {
        IWebDriver Driver;
        
        public BetslipObjects (IWebDriver driver)
        {
            Driver = driver;
        } 

        IWebElement spinAndWinIcon => Driver.FindElement(By.Id("SpinAndWin"));
        IWebElement highLowMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[5]/div[1]/h3"));
     //   IWebElement sectorColorMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[6]/div[3]"));
      //  IWebElement neighboursMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[3]/div/div[1]/div/div[10]/h3"));
         IWebElement manualStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[1]/div/div[2]/i"));
         
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));

        public void PlaceSinglebetsSW()
        {
            spinAndWinIcon.Click();
            Thread.Sleep(1000);

            highLowMarket.Click();
            Thread.Sleep(1000);
          //  sectorColorMarket.Click();
          //  Thread.Sleep(1000);
          //  neighboursMarket.Click();
          //  Thread.Sleep(1000);
          //  for (int i=1; i<=20; i++) {
          // manualStakeEdit.Click();
          //  }
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            var element = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div/div[1]/h3[2]/span[2]"));
            var value = element.GetAttribute("value");
            Console.WriteLine(value);

            /*
            var source = driver.PageSource  ;
            Console.WriteLine(source);
            submitBetSlip.Click();
            Thread.Sleep(1000);*/

        //Console.WriteLine(driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div/div[1]/h3[2]/span[2]")).GetDomAttribute("value"));

        }
    }
}