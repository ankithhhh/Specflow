using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ManagerStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public ManagerStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"manager login")]
        public void GivenManagerLogin()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"when manager clicks on manager login button")]
        public void WhenWhenManagerClicksOnManagerLoginButton()
        {
            IWebElement ManagerLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            ManagerLogin.Click();
            Thread.Sleep(2000);
        }

        [Then(@"click on add customer")]
        public void ThenClickOnAddCustomer()
        {
            IWebElement Addcus = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));
            Addcus.Click();
            Thread.Sleep(2000);
        }
        [Then(@"fill the fields name, lname and code")]
        public void ThenFillTheFieldsNameLnameAndCode(Table table)
        {
            IWebElement Name = _driver.FindElement(By.XPath("//input[@placeholder='First Name']"));

            Thread.Sleep(2000);
            IWebElement LName = _driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));

            Thread.Sleep(2000);
            IWebElement Code = _driver.FindElement(By.XPath("//input[@placeholder='Post Code']"));

            Thread.Sleep(2000);
            foreach (var an in table.Rows)
            {
                Name.SendKeys(an["name"]);
                LName.SendKeys(an["lname"]);
                Code.SendKeys(an["code"]);
            }

        }



        [Then(@"click on add customers")]
        public void ThenClickOnAddCustomers()
        {
            IWebElement Add = _driver.FindElement(By.XPath("//button[@type='submit']"));
            Add.Click(); ;
            Thread.Sleep(2000);
        }
    }
}
