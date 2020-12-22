using GiftreteMobileApp.Page_Objects;
using System;
using TechTalk.SpecFlow;

namespace GiftreteMobileApp.Step_Defination
{
    [Binding]
    public class RegistrationSteps
    {

        AutomationPage automationPage;

        public RegistrationSteps()
        {
            automationPage = new AutomationPage();
        }


        [Given(@"I have launched giftrete mobile app")]
        public void GivenIHaveLaunchedGiftreteMobileApp()
        {
            automationPage.ClickNext();
            automationPage.ClickNext();
            automationPage.ClickNext();
        }


        [When(@"I click on register")]
        public void WhenIClickOnRegister()
        {
            automationPage.ClickRegisterLink();
        }

        [When(@"I have entered my firstname ""(.*)""")]
        public void WhenIHaveEnteredMyFirstname(string first)
        {
            automationPage.EnterFirstname(first);
        }

        [When(@"I have entered my lastname ""(.*)""")]
        public void WhenIHaveEnteredMyLastname(string last)
        {
            automationPage.EnterLastname(last);
        }
        [When(@"I have entered my email address")]
        public void WhenIHaveEnteredMyEmailAddress()
        {

            automationPage.EnteredMyEmailAddress();
        }
       
        [When(@"I have entered my mobile ""(.*)""")]
        public void WhenIHaveEnteredMyMobile(string mobile)
        {
            automationPage.EnterMobile(mobile);
        }

        [When(@"I have entered my password ""(.*)""")]
        public void WhenIHaveEnteredMyPassword(string password)
        {
            automationPage.EnterPassword(password);
        }

        [When(@"I have re confirmed my password ""(.*)""")]
        public void WhenIHaveReConfirmedMyPassword(string repassword)
        {
            automationPage.ReEnterPassword(repassword);
        }

        [When(@"I click register")]
        public void WhenIClickRegister()
        {
            automationPage.ClickRegisterBtn();
        }

        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            automationPage.AssertHomePage();
        }

    }
}
