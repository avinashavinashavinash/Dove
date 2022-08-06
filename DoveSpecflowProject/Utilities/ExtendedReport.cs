

using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using TechTalk.SpecFlow;


namespace DoveSpecflowProject.Utilities
    {
    [Binding]
    public class ExtendedReport
        {


        public static ExtentReports extent;

        public static ExtentTest feature;
        public static ExtentTest scenario;




        [BeforeFeature]

        public static void featureBrowser( FeatureContext featureContext )
            {
            feature = extent.CreateTest<Feature>( featureContext.FeatureInfo.Title );
            }

        [BeforeScenario]
        public static void OpenBrowser( ScenarioContext scenarioContext )
            {
            scenario = feature.CreateNode<Scenario>( scenarioContext.ScenarioInfo.Title );

            }



        [BeforeTestRun]
        public static void GenerateReport( )
            {



            var Path1 = System.Reflection.Assembly.GetCallingAssembly( ).CodeBase;


            var Path2 = Path1.Substring( 0, Path1.LastIndexOf( "bin" ) );

            var Path3 = new Uri( Path2 ).LocalPath;

            Directory.CreateDirectory( Path3.ToString( ) + "Reports" );


            var Path4 = Path3 + "Reports\\ExtentReport" + DateTime.Now.ToString( "_MMddyyyy_hhmmtt" ) + ".html";



            extent = new ExtentReports( );

            var htmlreporter = new ExtentHtmlReporter( Path4 );

            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent.AttachReporter( htmlreporter );

            }

        [AfterTestRun]
        public static void CloseExtentReport( )
            {
            extent.Flush( );
            }

        [AfterStep]
        public static void InsertReportingSteps( ScenarioContext scenarioContext )
            {
            if(scenarioContext.TestError == null)
                {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString( );
                if(stepType == "Given")
                    scenario.CreateNode<Given>( ScenarioStepContext.Current.StepInfo.Text );
                if(stepType == "When")
                    scenario.CreateNode<When>( ScenarioStepContext.Current.StepInfo.Text );
                if(stepType == "And")
                    scenario.CreateNode<When>( ScenarioStepContext.Current.StepInfo.Text );
                if(stepType == "Then")
                    scenario.CreateNode<Then>( ScenarioStepContext.Current.StepInfo.Text );

                }
            if(scenarioContext.TestError != null)
                {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString( );
                if(stepType == "Given")
                    scenario.CreateNode<Given>( ScenarioStepContext.Current.StepInfo.Text ).Fail( scenarioContext.TestError.Message );
                if(stepType == "When")
                    scenario.CreateNode<When>( ScenarioStepContext.Current.StepInfo.Text ).Fail( scenarioContext.TestError.Message );
                if(stepType == "And")
                    scenario.CreateNode<When>( ScenarioStepContext.Current.StepInfo.Text ).Fail( scenarioContext.TestError.Message );
                if(stepType == "Then")
                    scenario.CreateNode<Then>( ScenarioStepContext.Current.StepInfo.Text ).Fail( scenarioContext.TestError.Message );
                }
            }


        }
    }


