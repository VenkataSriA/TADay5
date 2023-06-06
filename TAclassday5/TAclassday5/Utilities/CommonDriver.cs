using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TAclassday5.Pages;

namespace TAclassday5.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.Loginsteps(driver);
        }


        [OneTimeTearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}
