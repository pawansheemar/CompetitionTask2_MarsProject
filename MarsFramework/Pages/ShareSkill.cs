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
    class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region ShareSkill
        //Click on Shareskill Button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button']")]
        private IWebElement btnShareSkill { get; set; }

        //Entering Title
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement txtTitle { get; set; }

        //Error Msg for "Title"
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible'][contains(text(),'Special characters are not allowed.')]")]
        private IWebElement ErrorMsgTitle { get; set; }




        //Entering Description details
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement txtDescription { get; set; }

        //Error Msg for "Description"
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible'][contains(text(),'Special characters are not allowed.')]")]
        private IWebElement ErrorMsgDesc { get; set; }
        
        //Select Category from dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement drpCategory { get; set; }

     
        //Select Sub-Category from dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement drpSubCategory { get; set; }

        //Error Msg for "Category" Category is required.
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Category is required')]")]
        private IWebElement ErrorMsgCat { get; set; }

        //Entering Tags
        [FindsBy(How = How.XPath, Using = "//input[@class='ReactTags__tagInputField']")]
        private IWebElement txtTags { get; set; }

        //Error Msg for "Tags", when enter button pressed without entering any tag.
        [FindsBy(How = How.XPath, Using = "//div[@class='ui basic red prompt label transition visible']")]
        private IWebElement ErrorMsgTag { get; set; }

        //Select on Service type radio button
        //"Hourly basis Service" raadio button xpath
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement rdbtnHourlybasisservice { get; set; }
        //"One-off Service" radio button xpath
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement rdbtnOneoffservice { get; set; }
       


        //Select on Location type radio button
        //"On-site" radio button XPath
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement rdbtnOnSite { get; set; }

        //"Online" radio button XPath
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement rdbtnOnline { get; set; }

        //Select Start Date
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Start date')]")]
        private IWebElement addStartDate { get; set; }

        //Error Msg for "Start Date"
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Start Date cannot be set to a day in the past')]")]
        private IWebElement ErrorMsgStartDate { get; set; }

        //Select End Date
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'End date')]")]
        private IWebElement addEndDate { get; set; }

        //Error Msg for "End Date"
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Start Date shouldn't be greater than End Date')]")]
        private IWebElement ErrorMsgEndDate { get; set; }

        //Click on "Sunday" check-box
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[1]//div[1]//input[1]")]
        private IWebElement chkSunday { get; set; }

        //Enter start time
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'twelve wide column')]//div[2]//div[2]//input[1]")]
        private IWebElement txtStartTimeSunday { get; set; }

        //Enter end time
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'twelve wide column')]//div[2]//div[3]//input[1]")]
        private IWebElement txtEndTimeSunday { get; set; }

        //Click on "Monday" check-box
        [FindsBy(How = How.XPath, Using = "//div[3]//div[1]//div[1]//input[1]")]
        private IWebElement chkMonday { get; set; }

        //Enter start time "Monday"
        [FindsBy(How = How.XPath, Using = "//div[3]//div[2]//input[1]")]
        private IWebElement txtStartTimeMonday { get; set; }

        //Enter end time "Monday"
        [FindsBy(How = How.XPath, Using = "//body//div[3]//div[3]//input[1]")]
        private IWebElement txtEndTimeMonday { get; set; }

        //Click on "Tuesday" check-box
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[4]//div[1]//div[1]//input[1]")]
        private IWebElement chkTuesday { get; set; }

        //Enter start time "Tuesday"
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[4]//div[2]//input[1]")]
        private IWebElement txtStartTimeTuesday { get; set; }

        //Enter end time "Tuesday"
        [FindsBy(How = How.XPath, Using = "//div[4]//div[3]//input[1]")]
        private IWebElement txtEndTimeTuesday { get; set; }

        //Click on "Wednesday" check-box
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[5]//div[1]//div[1]//input[1]")]
        private IWebElement chkWednesday { get; set; }

        //Enter start time "Wednesday"
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[5]//div[2]//input[1]")]
        private IWebElement txtStartTimeWednesday { get; set; }

        //Enter end time "Wednesday"
        [FindsBy(How = How.XPath, Using = "//div[5]//div[3]//input[1]")]
        private IWebElement txtEndTimeWednesday { get; set; }

        //Click on "Thursday" check-box
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[6]//div[1]//div[1]//input[1]")]
        private IWebElement chkThursday { get; set; }

        //Enter start time "Thursday"
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[6]//div[2]//input[1]")]
        private IWebElement txtStartTimeThursday { get; set; }

        //Enter end time "Thursday"
        [FindsBy(How = How.XPath, Using = "//div[6]//div[3]//input[1]")]
        private IWebElement txtEndTimeThursday { get; set; }

        //Click on "Friday" check-box 
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[7]//div[1]//div[1]//input[1]")]
        private IWebElement chkFriday { get; set; }

        //Enter start time "Friday"
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[7]//div[2]//input[1]")]
        private IWebElement txtStartTimeFriday { get; set; }

        //Enter end time "Friday"
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[7]//div[3]//input[1]")]
        private IWebElement txtEndTimeFriday { get; set; }

        //Click on "Saturday" check-box
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[8]//div[1]//div[1]//input[1]")]
        private IWebElement chkSaturday { get; set; }

        //Enter start time "Saturday"
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']//div[8]//div[2]//input[1]")]
        private IWebElement txtStartTimeSaturday { get; set; }

        //Enter end time "Saturday"
        [FindsBy(How = How.XPath, Using = "//div[8]//div[3]//input[1]")]
        private IWebElement txtEndTimeSaturday { get; set; }

       

        //Select Skill Trade
        //click on "Skill Exchange" radio button
        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement rdbtnSkillExchange { get; set; }
        
        //Entering "Tags" under Skill-Exchange

        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement txtSkillExchangeTags { get; set; }

        //Click on "Credit" radio button
        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement rdbtnCredit { get; set; }

        //Entering "Credit" amount as per service
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement txtAmount { get; set; }

        //Upload File as "Work Sample"
        
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement rdbtnUpload { get; set; }

        //Select "Active" field to "Enable or Disable Service"
        //click on "Active" radio button
        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement rdbtnActive { get; set; }

        //click on "Hidden" radio button
        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement rdbtnHidden { get; set; }


        //click on "Save" button
        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'ui teal button')]")]
        private IWebElement btnsave { get; set; }

        [FindsBy(How = How.XPath, Using = " //h2[contains(text(),'Manage Listings')]")]
        private IWebElement MsgSave { get; set; }


       

        #endregion
       
        internal void AddShareSkill()
        {


            Base.test = Base.extent.StartTest("ShareSkill Test");


            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "ShareSkill");                   
           

            //Click on ShareSkill button
            btnShareSkill.Click();
           
            #region Title
            //Entering the "Title"
            txtTitle.Click();
            txtTitle.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
     
            #endregion

            #region Description
            //Entering the "Description"
            txtDescription.Click();
            txtDescription.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
           
            #endregion

            #region Category
            //Selecting Category
            new SelectElement(drpCategory).SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
           

            //Selecting SubCategory
            new SelectElement(drpSubCategory).SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
           
            drpSubCategory.SendKeys(Keys.Tab);
            
            #endregion

            #region Tags
            //Entering the "Tags"

            txtTags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
           
            txtTags.SendKeys(Keys.Enter);

            txtTags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AddNewTags"));
           
            #endregion

            #region ServiceType

            //Select Service type "Hourly basis service/One-off service"

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One off service")
                {
                rdbtnOneoffservice.Click(); 

            }
            else
            {
                rdbtnHourlybasisservice.Click();

            }

           

            //Select "Location Type" Onsite

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == "On Site")
            {
                rdbtnOnSite.Click();

            }
            else
            {
                rdbtnOnline.Click();

            }
           
            #endregion


            #region Availability days
            //Add "Start Date"           
            addStartDate.Click();
          addStartDate.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));

          //  if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartDate").Contains("?/@#"))
            //{
            //    ErrorMsgValidate();

            //}


          //  String Err = StartDateErrorMsg.GetAttribute("innerHTML");

         //   String ExpectedErr = "Special characters are not allowed.";
            //
           // if (ErrorMsg.GetAttribute("innerHTML") == ExpectedErr)
            //{
              //  Console.WriteLine("Special characters are not allowed");
         //   }
            //else
           // {
             //   Console.WriteLine("Special characters are allowed");

            //}



            // if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"))
            //  {
            //     ErrorMsgValidate();

            //   }
            //Add "End Date"
            addEndDate.Click();
            addEndDate.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            

            //Click on "Sunday" checkbox and enter "Start Time" 
            chkSunday.Click();
            txtStartTimeSunday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            

          //Click on "Sunday" checkbox and enter "End Time"     
            txtEndTimeSunday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            

            //Click on "Monday" checkbox and enter "Start Time"   
            chkMonday.Click();
            
            txtStartTimeMonday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Click on "Monday" checkbox and enter "End Time" 
            txtEndTimeMonday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            

            //Scrolling page
            Actions actions = new Actions(Global.GlobalDefinitions.driver);
            actions.MoveToElement(chkMonday);
            actions.Perform();

            //Click on "Tuesday" checkbox and enter "Start Time"   
            chkTuesday.Click();
            
            txtStartTimeTuesday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Click on "Tuesday" checkbox and enter "End Time" 
            txtEndTimeTuesday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            

            //Click on "Wednesday" checkbox and enter "Start Time"   
            chkWednesday.Click();
            
            txtStartTimeWednesday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Click on "Wednesday"  checkbox and enter "End Time" 
            txtEndTimeWednesday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            

            //Click on "Thursday" checkbox and enter "Start Time"   
            chkThursday.Click();
            
            txtStartTimeThursday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Click on "Thursday"  checkbox and enter "End Time" 
            txtEndTimeThursday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            

            //Click on "Friday" checkbox and enter "Start Time"   
            chkFriday.Click();
            
            txtStartTimeFriday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Click on "Friday"  checkbox and enter "End Time" 
            txtEndTimeFriday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            

            //Click on "Saturday" checkbox and enter "Start Time"   
            chkSaturday.Click();
            
            txtStartTimeSaturday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            
            //Click on "Saturday"  checkbox and enter "End Time" 
            txtEndTimeSaturday.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            
            #endregion

            #region Skill Exchange
            //Select Skill Exchange/Credit radio button under "Skill Trade" 
            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade") == "Skill Exchange")
            {
                rdbtnSkillExchange.Click();
                txtSkillExchangeTags.Click();
                txtSkillExchangeTags.SendKeys("C Sharp");
            }
            else
            {
                rdbtnCredit.Click();
                txtAmount.Click();
                txtAmount.SendKeys("5");
            }
            
            #endregion

            #region Upload Work Sample
            //Uploading Work Sample using "AutoIt"
            rdbtnUpload.Click();
            Thread.Sleep(2000);

            using (Process exeProcess = Process.Start("C:\\Mars_Project\\MarsFramework\\FileUpload.exe"))
            {
                exeProcess.WaitForExit();
            }

            #endregion
            //  Process.Start("E:\\FileUpload.exe");          // IRuntime.getRuntime().exec("E:\\FileUpload.exe");
           
            #region Service Status 
            //"Enable or disable your services status"
            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "Status") == "Hidden")
            {
                rdbtnActive.Click();

            }
            else
            {
                rdbtnHidden.Click();

            }
           
            #endregion

            #region Save button
            //Click on Save button
            btnsave.Click();
            Thread.Sleep(2000);
            
            string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]")).Text;

            if (text == "Manage Listings")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill Save Successful");
            }
            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Skill Save Unsuccessful");

            #endregion

            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            //return (wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by)));

        }

        internal void ErrorMsgValidate()
        {
            #region Title
            //Validation for "Title" Field
            String Err = ErrorMsgTitle.GetAttribute("innerHTML");

            String ExpectedErr = "Special characters are not allowed.";

            if (Err == ExpectedErr)
            {
                Console.WriteLine("Special characters are not allowed");
            }
            else
            {
                Console.WriteLine("Special characters are allowed");

            }
            #endregion

            #region Description
            //Validation for "Description" Field
            String ErrDesc = ErrorMsgDesc.GetAttribute("innerHTML");

            String ExpectedErrDesc = "Special characters are not allowed.";

            if (ErrDesc == ExpectedErrDesc)
            {
                Console.WriteLine("Special characters are not allowed");
            }
            else
            {
                Console.WriteLine("Special characters are allowed");

            }
            #endregion

            #region Category
            //Validation for "Category" field
            String ErrCat = ErrorMsgCat.GetAttribute("innerHTML");

            String ExpectedErrCat = "Caregory is required.";

            if (ErrCat == ExpectedErrCat)
            {
                Console.WriteLine("Caregory is required");
            }
            else
            {
                Console.WriteLine("Caregory is not required");

            }
            #endregion

            #region Tags

            //Validation for "Tags"
            String ErrTag = ErrorMsgTag.GetAttribute("innerHTML");

            String ExpectedErrTag = "Please enter a tag.";

            if (ErrTag == ExpectedErrTag)
            {
                Console.WriteLine("Please enter a tag");
            }
            else
            {
                Console.WriteLine("Tag is entered in the textbox");

            }
            #endregion

            #region Start Date
            //Validation for "Start Date"
            String ErrStartDate = ErrorMsgStartDate.GetAttribute("innerHTML");

            String ExpectedErrStartDate = "Start Date cannot be set to a day in the past";

            if (ErrStartDate == ExpectedErrStartDate)
            {
                Console.WriteLine("Start Date cannot be set to a day in the past");
            }
            else
            {
                Console.WriteLine("Start Date can be set to a day in the past");

            }

            #endregion

            #region End Date
            //Validation for "End Date"
            String ErrEndDate = ErrorMsgEndDate.GetAttribute("innerHTML");

            String ExpectedErrEndDate = "Start Date shouldn't be greater than End Date";

            if (ErrEndDate == ExpectedErrEndDate)
            {
                Console.WriteLine("Start Date shouldn't be greater than End Date");
            }
            else
            {
                Console.WriteLine("Start Date should be greater than End Date");

            }
            #endregion

        }


    }
}