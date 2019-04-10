Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


	Scenario: Vasya with drink water with friends
	Given Vasya have 100 liters of water
	And Vasya have 4 friends 
	When Vasya drinking 3 liters water in day and his friends drinking 4 liters water in day for week
	Then Vasya left -33 liters of water

	Scenario: Vasya eat apples and drink water alone
	Given Vasya have 100 liters of water 
	And Vasya have 27 apples
	When Vasya drinking 3 liters water in day for week
	And Vasya eating 3 apples in day for week
	Then Vasya left 79 liters of water and 6 apples

	Scenario: Vasya eat apples and drink water with friends
	Given Vasya have 100 liters of water
	And Vasya have 27 apples
	And Vasya have 4 friends
	When Vasya drinking 3 liters water in day and eating 3 apples in day for week
	And Vasya's friends drinking 4 liters water in day and eating 1.5 apples in day for week
	Then Vasya left -33 liters of water and 0 apples

	Scenario: Vasya's friends eat apples and drink water 
	Given Vasya have 100 liters of water
	And Vasya have 27 apples
	And Vasya have 4 friends
	When Vasya's friends drinking 4 liters water in day and eating 6.75 apples in day for week
	Then Vasya left -12 liters of water and 0 apples

