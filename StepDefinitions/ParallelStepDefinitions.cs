using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject.StepDefinitions
{ 
   
    [Binding]
    public class ParallelStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        public ParallelStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
            

            }
        [Given(@"user is on the application page on IE Browser")]
        public void GivenUserIsOnTheApplicationPageOnIEBrowser()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.in/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }

        [Given(@"user is on the application page on FF Browser")]
        public void GivenUserIsOnTheApplicationPageOnFFBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Given(@"user is on the application page on Edge Browser")]
        public void GivenUserIsOnTheApplicationPageOnEdgeBrowser()
        {
            _driver.Navigate().GoToUrl("https://www.w3schools.com/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
