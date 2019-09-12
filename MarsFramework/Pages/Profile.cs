using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;


namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        ////Click on Edit Availability Edit button
        [FindsBy(How = How.XPath, Using = "//i[@class='right floated outline small write icon']")]
        private IWebElement ProfileEdit { get; set; }

        ////Click on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")]
        private IWebElement AvailabilityTime { get; set; }

        ////Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//select[@class='ui right labeled dropdown']//option")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        ////Click on Edit Availability Hours
        [FindsBy(How = How.XPath, Using = "//div[@class='extra content']//div[3]//div[1]//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityHours { get; set; }


        ////Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']//option[contains(text(),'Less than 30hours a week')]")]
        private IWebElement AvailabilityHourss { get; set; }

        ////Click on Edit Salary
        [FindsBy(How = How.XPath, Using = "//div[@class='four wide column']//div[4]//div[1]//i[@class='right floated outline small write icon']")]
        private IWebElement EditSalary { get; set; }

        ////Click on salary option
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']//option[3]")]
        private IWebElement SalaryOpt { get; set; }

        ////Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        ////Choose Location
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        //private IWebElement LocationOpt { get; set; }

        //////Click on City
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        //private IWebElement City { get; set; }

        ////Choose City
       // [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        //private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How =How.XPath,Using = "//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
       private IWebElement AddNewLangBtn { get; set; }

        ////Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
         private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
       [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
       private IWebElement ChooseLang { get; set; }

    //    //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Conversational']")]
       private IWebElement ChooseLangOpt { get; set; }

        //Add Language
       [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
       private IWebElement AddLang { get; set; }

        //Skills tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
        private IWebElement SkillTab { get; set; }


        

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//select[@name='level']")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Beginner')]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//span[@class='buttons-wrapper']//input[contains(@class,'ui teal button')]")]
        private IWebElement AddSkill { get; set; }


        //Click on  Educaiton Tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(text(),'Education')]")]
        private IWebElement EducationTab { get; set; }



        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'New Zealand')]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'B.Tech')]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'2017')]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide field']//input[contains(@class,'ui teal button')]")]
        private IWebElement AddEdu { get; set; }


        //Click on  Cwertificate  Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Certifications')]")]
        private IWebElement CertificateTab { get; set; }


        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']//option[contains(text(),'2016')]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//div[@class='five wide field']//input[contains(@class,'ui teal button')]")]
        private IWebElement AddCerti { get; set; }


        [FindsBy(How = How.XPath, Using = "//i[@class='outline write icon']")]
        private IWebElement EditDescription { get; set; }




        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]")]
        private IWebElement Save { get; set; }

        #endregion

        internal void EditProfile()
        {
            Base.test = Base.extent.StartTest("Edit Profile Test");

            ////Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            ////Click on Edit button
            ProfileEdit.Click();
            
            ////Availability Time option
           // Thread.Sleep(1500);
            Actions action = new Actions(GlobalDefinitions.driver);
            action.MoveToElement(AvailabilityTime).Build().Perform();
          //  Thread.Sleep(1000);
            IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
            int count = AvailableTime.Count;
            for(int i = 0; i < count; i++)
            {
                if(AvailableTime[i].Text==GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                {
                    AvailableTime[i].Click();
                    Base.test.Log(LogStatus.Info, "Select the available time");

                }
            }
         //   Thread.Sleep(2000);
            

            // Thread.Sleep(2000);

          //  //Availability Hours
            AvailabilityHours.Click();
            //new SelectElement(AvailabilityHours).SelectByText("As needed");
            // // Availability Hours option
            AvailabilityHourss.Click();
          //  AvailabilityHours.SendKeys(Keys.Enter);
          //   Thread.Sleep(2000);

          //  //Salary 
            EditSalary.Click();
            // // new SelectElement(Salary).SelectByText("More than $1000 per month");
            //  //Choose the option from salary dropdown
            Thread.Sleep(500);
            SalaryOpt.Click();
           // SalaryOpt.SendKeys(Keys.ArrowDown);
         Thread.Sleep(500);
        //  SalaryOpt.SendKeys(Keys.Enter);

            ////Choose Location
            Thread.Sleep(1000);
            //action.MoveToElement(Location).Build().Perform();
            //Thread.Sleep(1000);
            //IList<IWebElement> LocCountry = LocationOpt.FindElements(By.TagName("div"));
            //int countrycount = LocCountry.Count;
            //for(int i = 0; i < countrycount; i++)
            //{
            //    if(LocCountry[i].Text == GlobalDefinitions.ExcelLib.ReadData(2,"Country"))
            //    {
            //        LocCountry[i].Click();
            //        Base.test.Log(LogStatus.Info, "Selected Country");
            //    }
            //}

            ////Choose City
            //Thread.Sleep(1000);
            //action.MoveToElement(City).Build().Perform();
            //Thread.Sleep(1000);
            //IList<IWebElement> LocCity = CityOpt.FindElements(By.TagName("div"));
            //int citycount = LocCity.Count;
            //for (int i = 0; i < citycount; i++)
            //{
            //    if (LocCity[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "City"))
            //    {
            //        LocCity[i].Click();
            //        Base.test.Log(LogStatus.Info, "Selected City");
            //    }
            //}


            //---------------------------------------------------------
            //Click on Add New Language button
            AddNewLangBtn.Click();
            //Thread.Sleep(1000);
            ////Enter the Language
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Language"));

            //Choose Lang
            ChooseLang.Click();
            Thread.Sleep(2000);
            ChooseLang.SendKeys("Conversational");
           // ChooseLangOpt.Click();
            Thread.Sleep(500);
           AddLang.Click();
            Base.test.Log(LogStatus.Info, "Added Language successfully");

            //-----------------------------------------------------------
            //Click on Add New Skill Button
            SkillTab.Click();

            AddNewSkillBtn.Click();
            //Enter the skill 
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Skill"));

            //Click the skill dropdown
            ChooseSkill.Click();
            Thread.Sleep(500);
            ChooseSkilllevel.Click();
            Thread.Sleep(500);
            AddSkill.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Skills successfully");

            //---------------------------------------------------------
            EducationTab.Click();
            //Add Education
            AddNewEducation.Click();
            Thread.Sleep(500);
            //Enter the University
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"University"));

            //Choose Country
            ChooseCountry.Click();
            Thread.Sleep(500);
            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();
            Thread.Sleep(500);
            ChooseTitleOpt.Click();

            //Enter Degree
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Degree"));

            //Year of Graduation
            DegreeYear.Click();
            Thread.Sleep(500);
            DegreeYearOpt.Click();
            AddEdu.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Education successfully");

            //-------------------------------------------------
            //Add new Certificate
            CertificateTab.Click();

            AddNewCerti.Click();

            //Enter Certificate Name
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Certificate"));

            //Enter Certified from
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"CertifiedFrom"));

            //Enter the Year
            CertiYear.Click();
            Thread.Sleep(500);
            CertiYearOpt.Click();
            AddCerti.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Certificate successfully");

            //-----------------------------------------------------
            //Add Description
            EditDescription.Click();
            Thread.Sleep(500);
            Description.Click();
            Thread.Sleep(500);
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Description"));
            Thread.Sleep(500);
           
            Base.test.Log(LogStatus.Info, "Added Description successfully");
            Save.Click();
        }
    }
}