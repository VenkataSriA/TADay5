using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.DOM;
using System.Xml.Linq;
using TAclassday5.Utilities;

namespace TAclassday5.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // creating new record             

            // click on create new
            IWebElement createnew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnew.Click();
            
            // select typecode
            IWebElement typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typecode.Click();
            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();
            
            // input code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("May2023");

            // input descrption
            IWebElement desc = driver.FindElement(By.Id("Description"));
            desc.SendKeys("Day6");

            // input pricepeerunit
            IWebElement priceunit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceunit.SendKeys("2023");

            // save
            IWebElement save = driver.FindElement(By.Id("SaveButton"));
            save.Click();
            Thread.Sleep(3000);
        
        
            //goto last page            
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();

            //search for last item
            Thread.Sleep(2000);
            IWebElement lastitemcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastitemcode.Text == "May2023")
            { Console.WriteLine("new record added successfully"); }

            else { Console.WriteLine("adding new record fail"); }

        }

        public void EditTM(IWebDriver driver)
        {
            //go to last page
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]", 5);
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();

            // edit the record
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 5);
            IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            edit.Click();

            IWebElement editdesc = driver.FindElement(By.Id("Description"));
            editdesc.Clear();
            Thread.Sleep(1000);

            editdesc.SendKeys("Edited");
            Thread.Sleep(1000);

            IWebElement save = driver.FindElement(By.Id("SaveButton"));
            save.Click();
            Thread.Sleep(2000);

            // check for edited item            
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]", 6);
            IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage1.Click();            
            Thread.Sleep(3000);
            IWebElement description = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            if (description.Text == "Edited")
            {              

                Console.WriteLine("Edited Successfully");                             
                
            }
        }

        public void DeleteTM(IWebDriver driver)
        {
            //to delete the item.
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]", 6);
            Thread.Sleep(2000);
            IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage1.Click();
            Thread.Sleep(2000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
                
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept(); //alert.dismiss(); to dismiss the message                    
            Thread.Sleep(4000);
            //Wait.WaitToExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[1]", 5)
            
            lastPage1.Click();
            IWebElement lastItem = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

                if (lastItem.Text == "May2023") 
                {
                    Console.WriteLine("Item delete unsuccessful");
                }
                else
                {
                    Console.WriteLine("Item deleted successfully");
                }

        }
    }
}
