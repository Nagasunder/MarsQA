Feature: ProfileName
	

@mytag
Scenario: Update ProfileName
	Given Click on ProfileName
	And Click on firstname
	And Clear the Firstnamw
	And Enter new name
	And Click on second name
	And Clear the secondname
	And Enter new second name
	When the firstname and secondname updated
	Then the click on save button