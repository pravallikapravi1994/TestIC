using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2.pages
{
    class TMpage
    {
        public void createTM(IWebDriver driver)
        {
            // Create Time and Material page
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']/../li[2]")).Click();
            driver.FindElement(By.Id("Code")).SendKeys("Automationcode1");
            driver.FindElement(By.Id("Description")).SendKeys("First automation on Time and Material");


            // driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("980");

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]//input[1]")).SendKeys("123");
            IWebElement upload = driver.FindElement(By.Id("files"));
            upload.SendKeys("C:\\IndustryConnectMaterial\\Devops.PNG");
            driver.FindElement(By.Id("SaveButton")).Click();
        }

        public void EditTM(IWebDriver driver)
        {
            // Edit Time and Material

         

            Thread.Sleep(2000);

            var table = driver.FindElement(By.TagName("table"));
            var rows = table.FindElements(By.TagName("tr"));

            Thread.Sleep(2000);
            var col = table.FindElement(By.XPath("//*[@id='tmsGrid']//tbody/tr[1]/td[5]/a[1]"));
            col.Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("Code")).Clear();
            driver.FindElement(By.Id("Code")).SendKeys("Automationcode1");
            driver.FindElement(By.Id("SaveButton")).Click();

        }
        public void DeleteTM(IWebDriver driver)
        {


            Thread.Sleep(2000);

            var table2 = driver.FindElement(By.TagName("table"));
            var rows2 = table2.FindElements(By.TagName("tr"));

            var col2 = table2.FindElement(By.XPath("//*[@id='tmsGrid']//tbody/tr[1]/td[5]/a[2]"));
            col2.Click();
            Thread.Sleep(1000);

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(1000);

        }
    }
}
