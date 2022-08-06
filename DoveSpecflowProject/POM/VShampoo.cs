
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


using DoveSpecflowProject.Hooks;

namespace DoveSpecflowProject.POM
    {
    public class VShampoo
        {
        public void NavUrlDoveWeb( )
            {
            BasePageClass._driver.Navigate( ).GoToUrl( "https://www.dove.com/in/home.html" );

            LogFourNetLog.log.Info( "VerifyShampoo" );
            }

      public void SearchForShampoo( )
            {

            Thread.Sleep( 5000 );
            BasePageClass._driver.FindElement( By.XPath( "//button[@class='o-navbar-label js-search-btn']" ) ).Click( );

            Thread.Sleep( 5000 );

            BasePageClass._driver.FindElement( By.XPath( "(//input[@class='c-global-search__textbox form-control typeahead tt-input'])[2]" ) ).SendKeys( "shampoo" );


            Thread.Sleep( 5000 );
            BasePageClass._driver.FindElement( By.XPath( "(//button[@class='hidden-xs o-btn o-btn--ternary js-btn-search'])[2]" ) ).Click( );



            LogFourNetLog.log.Info( "VerifyShampoo" );
            }


        public void VerifyShampoo( )
            {
            string text1 = BasePageClass._driver.FindElement( By.XPath( ".//h2[text()='Baby Shampoo']" ) ).Text;

            
            if(text1.Contains( "Baby Shampoo" ))
                {
                Console.WriteLine( "present" );
                }
            else
                {
                Console.WriteLine( "not present" );
                }

            LogFourNetLog.log.Info( "VerifyShampoo" );
            }

        public void ScreenShot( )
            {
            ((ITakesScreenshot)BasePageClass._driver).GetScreenshot( ).SaveAsFile( @"C:\\Users\\Avinash\\source\\repos\\DoveSpecflowProject\\DoveSpecflowProject\\Reports\\new1.png" );
            }


        }
    }
