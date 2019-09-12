using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Support;
using System.Diagnostics;

namespace MarsFramework.Pages
{
    class ManageListing
    {
           
        public ManageListing()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        
            //Click on ManageListings Button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement btnManageListing { get; set; }

        //Click on Scroll Button to change service status (Enable/Disable service)
        [FindsBy(How = How.XPath, Using = "//tr[1]//td[7]//div[1]//input[1]")]
        private IWebElement btnScroll { get; set; }

        //Click on Cross Arrow Button to delete skill from listing page
        [FindsBy(How = How.XPath, Using = "//tr[1]//td[8]//i[3]")]
        private IWebElement btnDelete { get; set; }

        
        //Click on "Yes" Button to delete skill from listing page
        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement btnYesDelete { get; set; }

        internal void addmanagelisting()
        {

            Base.test = Base.extent.StartTest("Manage Listing Test");

            //Click on ManageListing tab
            btnManageListing.Click();
            Thread.Sleep(3000);
            //Click on Scroll button
            btnScroll.Click();
            Thread.Sleep(3000);
            //Delete list from listing page
            btnDelete.Click();
            Thread.Sleep(3000);
            //Click on "Yes" button to delete listing
            btnYesDelete.Click();

            //Close browser


            //

        }
    }
}




