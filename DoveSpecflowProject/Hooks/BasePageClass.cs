using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;


namespace DoveSpecflowProject.Hooks
    {

    [Binding]
    public class BasePageClass
        {

        public static IWebDriver _driver;



        [BeforeScenario]
        public static void Webloading( )
            {



            FirefoxOptions firefoxOptions = new FirefoxOptions( );
            firefoxOptions.AddArguments( "-private-window" );

            _driver = new FirefoxDriver( firefoxOptions );



            _driver.Manage( ).Timeouts( ).ImplicitWait = TimeSpan.FromSeconds( 60 );
            _driver.Manage( ).Window.Maximize( );

            }

        [AfterScenario]
        public static void QuitBrowser( )
            {
            _driver.Quit( );
            }
        }
    }



