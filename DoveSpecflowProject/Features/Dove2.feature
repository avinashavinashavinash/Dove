Feature: Dove2

Navigate to URL. 
Click on “Discover more” under “Let's #StopTheBeautyTest” module in the home page. 
In Let's #StopTheBeautyTest page, verify if we have text “The Real Women behind #StopTheBeautyTest” in the page

@tag1
Scenario: In Let's #StopTheBeautyTest page, verify if we have text "The Real Women behind #StopTheBeautyTest" in the page
	Given Navigate to the URL1
	When Click on "Discover more" under "Let's #StopTheBeautyTest" module in the home page
	Then verify if we have text "The Real Women behind #StopTheBeautyTest" in the page
