Feature: UpdateEducation
	

@mytag
Scenario: Update Education in profile page
	Given Click On Education tab
	And click on the edit icon
	And Clear the Current education 
	And Update new education
	And Country of college / university from dropdown
	And Select degree type from the dropdown
	And Clear the current degree
	And Update new degree
	And Select year of graduation from dropdown
	Then Click on Update education