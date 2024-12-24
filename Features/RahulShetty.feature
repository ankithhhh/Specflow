@Sprint1
Feature: RahulShetty

A short summary of the feature


@Regression
Scenario: Verify login for RahulShetty website
 
	Given User is on the RahulShetty login page
 
	When User enters the "<username>" and "<email>" and "<password>" in the text fields
 
	And user slects "<gender>", and "<dob>" fields
 
 


Examples:
 
| username | email               | password | gender | dob        |
 
| Ravi     | ravigupta@gmail.com | ravi234  | Male   | 2003-02-19 |

| sam      | samy@gmail.com      | sam123   | Female | 2002-11-20 |
 
