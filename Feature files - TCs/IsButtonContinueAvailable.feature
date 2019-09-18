Feature: User can continue to the last checkout step.
	In order to proceed to Personal Data checkout step
	As a new user
	I need to select a Promotion or a Promotion and a Subscription
	So button Continue becomes active.

 Scenario: BOX za 1 EUR - No Subscription - Button is inactive
  Given that I selected Box option
   When I select "BOX za 1 EUR" Promotion
   Then button Continue is inactive.

 
 Scenario: 3 meseca gratis - 3 months Subscription - Button is active
Given that I select No Box option
When I select "3 meseca gratis" Promotion
Then button Continue is active
  
 
 