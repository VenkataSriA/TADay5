using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAclassday5.Pages;
using TAclassday5.Utilities;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace TAclassday5.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        

        [SetUp]
        public void SetUpActions()
        {
            driver = new ChromeDriver();

            LoginPage loginpageobj = new LoginPage();
            loginpageobj.Loginsteps(driver);

            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);
        }

        [Test, Order (1)]
        public void CreateTime_Test()
        {

            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);

        }

        [Test, Order(2)]
        public void EditTime_Test()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.EditTM(driver);
        }

        [Test, Order(3)]
        public void DeleteTime_Test()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.DeleteTM(driver);
        }

        [TearDown]       
        public void CloseTestRun()
        {
            driver.Quit();
        }
            
        
         

    }
}
