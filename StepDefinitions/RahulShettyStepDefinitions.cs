using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class RahulShettyStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public RahulShettyStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"User is on the RahulShetty login page")]
        public void GivenUserIsOnTheRahulShettyLoginPage()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndAndInTheTextFields(string username, string email, string password)
        {
            IWebElement Name = _driver.FindElement(By.XPath("//div[@class='form-group']//input[@name='name']"));
            Name.SendKeys(username);
            Thread.Sleep(2000);

            IWebElement Email = _driver.FindElement(By.XPath("//input[@name='email']"));
            Email.SendKeys(email);
            Thread.Sleep(2000);


            IWebElement Password = _driver.FindElement(By.XPath("//input[@id='exampleInputPassword1']"));
            Password.SendKeys(password);
            Thread.Sleep(2000);
        }

        [When(@"user slects ""([^""]*)"", and ""([^""]*)"" fields")]
        public void WhenUserSlectsAndFields(string gender, string dob)
        {
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                _driver.FindElement(By.XPath("//option[normalize-space()='Male']")).Click();
            }
            else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                _driver.FindElement(By.XPath("//option[normalize-space()='Female']")).Click();
            }

            IWebElement DOB = _driver.FindElement(By.XPath("//input[@name='bday']"));
            DOB.SendKeys(dob);
            Thread.Sleep(2000);
        }
    }
}
