
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


using DoveSpecflowProject.Hooks;

namespace DoveSpecflowProject.POM
    {
    public class StopBeautyTest
        {
        public void NavUrlDoveWeb( )
            {
            BasePageClass._driver.Navigate( ).GoToUrl( "https://www.dove.com/in/home.html" );


            LogFourNetLog.log.Info( "VerifyStopTheBeauty" );
            }

        public void DiscoverMore( )
            {

            Thread.Sleep( 3000 );
            IJavaScriptExecutor js = BasePageClass._driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep (3000);
            js.ExecuteScript ("window.scrollBy(0,550)");


            Thread.Sleep( 2000 );
            BasePageClass._driver.FindElement( By.XPath( "(//a[@class='o-btn o-btn--secondary'])[1]" ) ).Click( );



            LogFourNetLog.log.Info( "VerifyStopTheBeauty" );
            }


        public void VerifyStopTheBeauty( )
            {

            Thread.Sleep( 3000 );
            IJavaScriptExecutor js = BasePageClass._driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep( 3000 );
            js.ExecuteScript( "window.scrollBy(0,150)" );



            Thread.Sleep( 3000 );
            string text1 = BasePageClass._driver.FindElement( By.XPath( "(//h2[@class='o-text__heading-2'])[1]" ) ).Text;


            if(text1.Contains( "The Real Women behind #StopTheBeautyTest" ))
                {
                Console.WriteLine( "present" );
                }
            else
                {
                Console.WriteLine( "not present" );
                }


            LogFourNetLog.log.Info( "VerifyStopTheBeauty" );
            }

        public void ScreenShot( )
            {
            ((ITakesScreenshot)BasePageClass._driver).GetScreenshot( ).SaveAsFile( @"C:\\Users\\Avinash\\source\\repos\\DoveSpecflowProject\\DoveSpecflowProject\\Reports\\new2.png" );
            }
        }
    }
