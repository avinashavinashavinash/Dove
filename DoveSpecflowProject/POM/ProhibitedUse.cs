
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


using DoveSpecflowProject.Hooks;

namespace DoveSpecflowProject.POM
    {
    public class ProhibitedUse
        {
        public void NavUrlDoveWeb( )
            {
            BasePageClass._driver.Navigate( ).GoToUrl( "https://www.dove.com/in/home.html" );

            IJavaScriptExecutor js = BasePageClass._driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep( 3000 );
            js.ExecuteScript( "window.scrollBy(0,4000)" );



            LogFourNetLog.log.Info( "VerifyProhitets" );
            }

        public void TermsOfUse( )
            {

            Thread.Sleep( 2000);
            BasePageClass._driver.FindElement( By.XPath( " //a[@href='https://www.dove.com/in/terms-of-use.html']" ) ).Click( );



            LogFourNetLog.log.Info( "VerifyProhitets" );

            }


        public void VerifyProhitetsUse( )
            {
            Thread.Sleep( 5000 );

            string text1 = BasePageClass._driver.FindElement( By.XPath( "//b[text()='2. Prohibited Uses']" ) ).Text;


            if(text1.Contains( "2. Prohibited Uses" ))
                {
                Console.WriteLine( "present" );
                }
            else
                {
                Console.WriteLine( "not present" );
                }

            LogFourNetLog.log.Info( "VerifyProhitets" );
            }

        public void ScreenShot( )
            {
            ((ITakesScreenshot)BasePageClass._driver).GetScreenshot( ).SaveAsFile( @"C:\\Users\\Avinash\\source\\repos\\DoveSpecflowProject\\DoveSpecflowProject\\Reports\\new3.png" );
            }
        }
    }
