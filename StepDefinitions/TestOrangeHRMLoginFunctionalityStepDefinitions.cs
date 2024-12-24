using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
   
    [Binding]

    public class TestOrangeHRMLoginFunctionalityStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public TestOrangeHRMLoginFunctionalityStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }


        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {


            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {

            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));

            username.SendKeys(usrname);


            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));

            password.SendKeys(passwd);


        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {


            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            loginbutton.Click();

            Thread.Sleep(1000);


        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {

            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

            Admin.Click();

            Thread.Sleep(3000);

            }

            [Then(@"User is navigated to homepage")]

            public void ThenUserIsNavigatedToHomepage()

            {

                Console.WriteLine("Entered to home page");

            }
        [Then(@"User is on the home page and a error is displayed")]
        public void ThenUserIsOnTheHomePageAndAErrorIsDisplayed()
        {
            Console.WriteLine("invalid password v  ");
        }


    }


}


