using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class XYZBankStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XYZBankStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@": User in on login page")]
        public void GivenUserInOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [When(@"Customer clicks on Customer Login button")]
        public void WhenCustomerClicksOnCustomerLoginButton()
        {
            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            CustLogin.Click();
        }

        [When(@"select the name")]
        public void WhenSelectTheName()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
            NamesDropDown.Click();
            var select = new SelectElement(NamesDropDown);
            Thread.Sleep(2000);
            select.SelectByText("Harry Potter");
            Thread.Sleep(2000);
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            NamesDropDown.Click();
        }

        [Then(@"User logs and can see data")]
        public void ThenUserLogsAndCanSeeData()
        {
            Console.WriteLine("Customer Logged In");
        }
    }
}
