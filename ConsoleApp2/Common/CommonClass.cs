using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ConsoleApp2.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Common
{
    class CommonClass
    {

        public IWebDriver driver { get; set; }

        //[OneTimeSetUp]
        //public void TestSetUpTM()
        //{
        //    // define driver
        //    driver = new ChromeDriver();

        //    // login page object
        //    Login loginObj = new Login();
        //    loginObj.login(driver);

        //    // home page object
        //    Home homeObj = new Home();
        //    homeObj.navigateToTM(driver);
        //}




        //[OneTimeTearDown]
        //public void TestTearDown()
        //{
        //    driver.Quit();
        //}



    }
}
