Feature: Dove1

Verify the text “shampoo” .

@tag1
Scenario: Verify the text “shampoo” appears in first item in the search results list as per the below screen shot
	Given Navigates to the URL
	When Click on search and search for shampoo
	Then Verify the text “shampoo” appears in first item in the search results list as per the below screen shot.
