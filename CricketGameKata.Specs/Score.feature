Feature: Batter Score
	In order to build a cricket game
	As a developer
	I want to calculate the batter's score.

@mytag
Scenario: Batsman gets out without scoring
	Given I have started a new game
	When Batsman gets out
	Then Batsman score should be 0
