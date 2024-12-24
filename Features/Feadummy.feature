@Sprint1
Feature: Feadummy


Scenario Outline: Verify login with test parameters
When user enters the "<username>" and "<password>"
And user click on login button
Then user navigate to home page 
Then user selects the city and country information
| city   | country |
| delhi  | India   |
| Boston | USA     |
Examples:  
| username | password |
| ankith   | ank123   |
| havan    | hav123   |