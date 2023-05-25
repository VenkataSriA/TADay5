﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TAclassday5.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds) //line1
        {

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)); //line2
            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue))); //line3
                                                                                                                        //line2 is implicit wait
                                                                                                                        //line2,3 is explicit
                                                                                                                        //line1,2,3 is fluent
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }
        public static void WaitToExist(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)); //line2
            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }

        }


    }
}
