using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        [When(@"user enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("the username is "+ username + "......"+ "the password is "+ password);
        }

        [When(@"user click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            Console.WriteLine(" user clicks on login button");
        }

        [Then(@"user navigate to home page")]
        public void ThenUserNavigateToHomePage()
        {
            Console.WriteLine("user is on the home page");
        }

        [Then(@"user selects the city and country information")]
        public void ThenUserSelectsTheCityAndCountryInformation(Table table)
        {
           foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city+","+country);

            }
        }
    }
}
