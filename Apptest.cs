using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;



namespace GiftreteMobileApp
{
    

    [TestClass]
    public class AppTest
    {
        AppiumDriver<IWebElement> driver;
       //AndroidDriver<IWebElement> driver;
        //IOSDriver<IWebElement> driver;

        [TestMethod]
        public void TestMethod1()
        {
            // setupn desired capabilities
            AppiumOptions cap = new AppiumOptions();
            cap.AddAdditionalCapability("deviceName","MyPhone");
            cap.AddAdditionalCapability("platformName","Android");
            cap.AddAdditionalCapability("platformVersion","8.0");
            cap.AddAdditionalCapability("udid", "988633474237324346");
            cap.AddAdditionalCapability("appPackage","gift.giftrete.com");
            cap.AddAdditionalCapability("appActivity","gift.giftrete.com.SplashScreenActivity");


            //set up the url for appium server to lauch the automation session

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            

            //gather element for writing test
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.FindElementById("txtnext").Click();
            driver.FindElementById("txtnext").Click();
            driver.FindElementById("txtnext").Click();

            driver.FindElementById("email").SendKeys("moscoade690@yahoo.com");
            driver.FindElementById("password").SendKeys("tester!");
            driver.FindElementById("button").Click();

            IWebElement GiftreteLogo = driver.FindElementById("titletxt");
            IWebElement RegisterBtn = driver.FindElementById("signup");


            if (GiftreteLogo.Displayed)
            {
                Assert.That(RegisterBtn.Displayed, Is.True);
            }
            else if (!GiftreteLogo.Displayed)
            {
                Assert.That(RegisterBtn.Displayed, Is.False);
            }

        }

    }
}
