using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace TAclassday5
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           // day5
           // open chrome,maximize, and go to the website
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

            //check if the user is hari
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (user.Text == "Hello hari!")
            {
                Console.WriteLine("login success");
            }
            else {
                Console.WriteLine("login failed");
            }
            // day6
            // creating new record 
            // go to administration tab
            IWebElement admintab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admintab.Click();

            // select time and materials from drop down
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

            // click on create new
            IWebElement createnew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnew.Click();

            // select typecode
            IWebElement typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecode.Click();
            IWebElement time = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
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
            Thread.Sleep(1000);
            // check whether it is added
            //goto last page
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(1000);
            //search for last item
            IWebElement lastitem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastitem.Text == "May2023")
            { Console.WriteLine("new record added successfully"); } 
            else { Console.WriteLine("adding new record fail"); }

            Thread.Sleep(3000);
            //day6 edit and delete an item
            // to edit the item
            IWebElement price = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            if (price.Text == "$2,023.00")
            {
                IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                  edit.Click();
                IWebElement editdesc = driver.FindElement(By.Id("Description"));
                editdesc.Clear();
                Thread.Sleep(1000);
                editdesc.SendKeys("Edited");
                Thread.Sleep(2000);
                IWebElement saveedit = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
                saveedit.Click() ;
                Console.WriteLine("Edited Successfully");
                Thread.Sleep(2000);
                lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                                  //it means that the element has become stale between the time
                                  //it was initially located and when you try to access it again.
                lastpage.Click();

                //to delete the item.

                IWebElement del = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                del.Click();
                Thread.Sleep(2000);
                IAlert alert = driver.SwitchTo().Alert();   
                Thread.Sleep(2000);
                // Print the alert message (optional)
                //Console.WriteLine("Alert Message: " + alert.Text);
                //Thread.Sleep(2000);
                alert.Accept(); //alert.dismiss(); to dismiss the message
                Console.WriteLine("Item deleted successfully");
            }
            else { Console.WriteLine("Item not found"); }

            driver.Quit();

        }
    }   } 
      