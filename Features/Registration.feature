Feature: Registration
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Registration
	Given I have launched giftrete mobile app
	When I click on register
	And I have entered my firstname "Adedoyin"
	And I have entered my lastname "Ade"
	And I have entered my email address
	And I have entered my mobile "07123456789"
	And I have entered my password "tester!"
	And I have re confirmed my password "tester!"
	And I click register
	Then I should be registered
