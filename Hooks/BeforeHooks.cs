using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace GiftreteMobileApp.Hooks
{ [Binding]
    public class BeforeHooks
    {
        public static AppiumDriver<IWebElement> driver;



        [BeforeScenario]
        public void BeforeScenario()
        {
            // setupn desired capabilities
            AppiumOptions cap = new AppiumOptions();
            cap.AddAdditionalCapability("deviceName", "MyPhone");
            cap.AddAdditionalCapability("platformName", "Android");
            cap.AddAdditionalCapability("platformVersion", "8.0");
            cap.AddAdditionalCapability("udid", "988633474237324346");
            cap.AddAdditionalCapability("appPackage", "gift.giftrete.com");
            cap.AddAdditionalCapability("appActivity", "gift.giftrete.com.SplashScreenActivity");


            //set up the url for appium server to lauch the automation session

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);



            //gather element for writing test
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
