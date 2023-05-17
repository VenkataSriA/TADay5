using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TAclassday5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // open chrome
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            
            // enter username in textbox
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // enter password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // click on login
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();

            //check user hari
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (user.Text == "Hello hari!")
            {
                Console.WriteLine("login success");
            }
            else { 
                Console.WriteLine("login failed");
            }
            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}