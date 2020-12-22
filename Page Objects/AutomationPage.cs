using GiftreteMobileApp.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.BindingSkeletons;
using Assert = NUnit.Framework.Assert;

namespace GiftreteMobileApp.Page_Objects
{  
    [Binding]
    class AutomationPage
    {
        AppiumDriver<IWebElement> driver = BeforeHooks.driver;
        
        IWebElement RegisterLink => driver.FindElementById("signup");
        IWebElement FirstName => driver.FindElementById("first");
        IWebElement LastName => driver.FindElementById("last");
        IWebElement Email => driver.FindElementById("email");
        IWebElement Mobile => driver.FindElementById("mobile");
        IWebElement Password => driver.FindElementById("password");
        IWebElement ConfirmPassword => driver.FindElementById("repassword");
        IWebElement RegisterBtn => driver.FindElementById("button");
        IWebElement GetStarted => driver.FindElementById("txtnext");
        IWebElement ProfileLink => driver.FindElementById("profilelink");
        IWebElement AccountName => driver.FindElementById("subtitle");
        public void ClickNext()
        {
            GetStarted.Click();
        }
        public void ClickRegisterLink()
        {
            RegisterLink.Click();
        }

        public void EnterFirstname(string firstname)
        {
            FirstName.SendKeys(firstname);
        }

        public void EnterLastname(string lastname)
        {
            LastName.SendKeys(lastname);
        }

        public void EnteredMyEmailAddress()
        {
            Random randomgenerator = new Random();
            int randomInt = randomgenerator.Next(1000);
            Email.SendKeys("moscoade" + randomInt + "@yahoo.com");
         
           
        }
        public void EnterMobile(string mobileno)
        {
            Mobile.SendKeys(mobileno);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void ReEnterPassword(string repassword)
        {
            ConfirmPassword.SendKeys(repassword);
        }

        public void ClickRegisterBtn()
        {
            RegisterBtn.Click();
        }

        public void AssertHomePage()
        {
            if (ProfileLink.Displayed)
            {
                Assert.That(AccountName.Displayed, Is.True);
            }
        }
    }

   
}
