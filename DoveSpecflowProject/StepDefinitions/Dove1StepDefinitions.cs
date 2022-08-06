using System;
using TechTalk.SpecFlow;
using DoveSpecflowProject.Hooks; 
using DoveSpecflowProject.POM;

namespace DoveSpecflowProject.StepDefinitions
{
  
   [Binding]
    public class Dove1StepDefinitions
    {

        VShampoo Shampoo = new VShampoo( );


        [Given( @"Navigates to the URL" )]
        public void GivenNavigatesToTheURL( )
            {
            Shampoo.NavUrlDoveWeb( );
            }


        [When(@"Click on search and search for shampoo")]
        public void WhenClickOnSearchAndSearchForShampoo()
        {
            Shampoo.SearchForShampoo( );
        }

        [Then(@"Verify the text “shampoo” appears in first item in the search results list as per the below screen shot\.")]
        public void ThenVerifyTheTextShampooAppearsInFirstItemInTheSearchResultsListAsPerTheBelowScreenShot_()
        {
            Shampoo.VerifyShampoo( );
            Shampoo.ScreenShot( );
        }
    }
}
