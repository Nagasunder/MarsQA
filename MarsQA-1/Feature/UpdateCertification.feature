Feature: UpdateCertification
	

@mytag
Scenario: Update certification in profile page
	Given Click on certification
	And Click on edit icon 
	And Clear previous certification
	And Enter new certification name
	And Clear From certification
	And Enter the new Certification
	And Select year from dropdown
	Then Click on Update button