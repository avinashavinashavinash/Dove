using DoveSpecflowProject.POM;
using System;
using TechTalk.SpecFlow;

namespace DoveSpecflowProject.StepDefinitions
{
    [Binding]
    public class Dove3StepDefinitions
    {

        ProhibitedUse pro = new ProhibitedUse( );

        [Given(@"Navigate to URLs")]
        public void GivenNavigateToURLs()
        {
            pro.NavUrlDoveWeb( );
        }

        [When(@"Click on “Terms of use” in Footer")]
        public void WhenClickOnTermsOfUseInFooter()
        {
            pro.TermsOfUse( );
        }

        [Then(@"Verify if we have section “Prohibited Uses” in the Terms of Use page")]
        public void ThenVerifyIfWeHaveSectionProhibitedUsesInTheTermsOfUsePage()
        {
            pro.VerifyProhitetsUse( );
            pro.ScreenShot( );
        }
    }
}
