Feature: Dove3

Navigate to URL. Click on “Terms of use” in Footer. Verify if we have section “Prohibited Uses” in the Terms of Use page

@tag1
Scenario: Verify if we have section Prohibited Uses in the Terms of Use page
	Given Navigate to URLs
	When Click on “Terms of use” in Footer
	Then Verify if we have section “Prohibited Uses” in the Terms of Use page
