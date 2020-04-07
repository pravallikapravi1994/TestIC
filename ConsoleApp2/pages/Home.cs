using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.pages
{
    class Home
    {
        public void Verifylogin(IWebDriver driver)
        {
            // Validation
            if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, Test passed");
            }
            else
            {
                Console.WriteLine("Login Failed, Test Failed");
            }
        }

        public void navigateToTM(IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

          
        }

    }
}
