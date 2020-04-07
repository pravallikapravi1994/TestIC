using ConsoleApp2.Common;
using ConsoleApp2.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {

        }


        [SetUp]
        public void setup()
        {

            CommonClass.driver = new ChromeDriver();

            //Login 
            Login login = new Login();
            login.login(CommonClass.driver);


            //Home 

            Home hmpage = new Home();
            hmpage.navigateToTM(CommonClass.driver);
        }

        //TM page

        // Create TM

        [Test]
        public void testCreateTM()
        {
            TMpage tm1 = new TMpage();
            tm1.createTM(CommonClass.driver);

        }

        [Test]
        public void EditTM()
        {
            //Edit TM
            TMpage tm2 = new TMpage();

            tm2.EditTM(CommonClass.driver);

        }

        [Test]
        //Delete TM
        public void DeleteTM()
        {
            TMpage tm3 = new TMpage();
            tm3.DeleteTM(CommonClass.driver);

        }


        [TearDown]
        public void ENd()
        {

            // QUit

            CommonClass.driver.Quit();



        }







    }






    


}

    
