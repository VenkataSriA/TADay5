using OpenQA.Selenium;
using TAclassday5.Utilities;

namespace TAclassday5.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // go to administration tab
            IWebElement admintab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admintab.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);
            // select time and materials from drop down
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
        }
    }
}
