using DoveSpecflowProject.POM;
using System;
using TechTalk.SpecFlow;

namespace DoveSpecflowProject.StepDefinitions
{
    [Binding]
    public class Dove2StepDefinitions
    {
        StopBeautyTest sBeauty = new StopBeautyTest( );

        [Given(@"Navigate to the URL(.*)")]
        public void GivenNavigateToTheURL(int p0)
        {
            sBeauty.NavUrlDoveWeb( );
        }

        [When(@"Click on ""([^""]*)"" under ""([^""]*)"" module in the home page")]
        public void WhenClickOnUnderModuleInTheHomePage(string p0, string p1)
        {
            sBeauty.DiscoverMore( );
            sBeauty.VerifyStopTheBeauty( );
        }

        [Then(@"verify if we have text ""([^""]*)"" in the page")]
        public void ThenVerifyIfWeHaveTextInThePage(string p0)
        {
            sBeauty.VerifyStopTheBeauty( );
            sBeauty.ScreenShot( );
        }
    }
}
