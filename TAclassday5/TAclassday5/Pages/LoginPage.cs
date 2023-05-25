using OpenQA.Selenium;

namespace TAclassday5.Pages
{
    public class LoginPage
    {
        public void Loginsteps(IWebDriver driver)
        {
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

            //check if the user is hari
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (user.Text == "Hello hari!")
            {
                Console.WriteLine("login success");
            }
            else
            {
                Console.WriteLine("login failed");
            }
        }

    }
}
