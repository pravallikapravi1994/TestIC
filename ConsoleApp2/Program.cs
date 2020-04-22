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
    }

        [TestFixture]
        class TimeAndMaterial : CommonClass

        {

            [OneTimeSetUp]
            public void setup()
            {

                driver = new ChromeDriver();

                //Login 
                Login login = new Login();
                login.login(driver);


                //Home 

                Home hmpage = new Home();
                hmpage.navigateToTM(driver);
            }

            //TM page

            // Create TM

            [Test]
            public void testCreateTM()
            {
                TMpage tm1 = new TMpage();
                tm1.createTM(driver);

            }

            [Test]
            public void EditTM()
            {
                //Edit TM
                TMpage tm2 = new TMpage();

                tm2.EditTM(driver);

            }

            [Test]
            //Delete TM
            public void DeleteTM()
            {
                TMpage tm3 = new TMpage();
                tm3.DeleteTM(driver);

            }


            [OneTimeTearDown]
            public void ENd()
            {

                // QUit

                driver.Quit();



            }







        }







        [TestFixture]
        class Customer : CommonClass
        {

            [OneTimeSetUp]
            public void setup()
            {

                driver = new ChromeDriver();

                //Login 
                Login login = new Login();
                login.login(driver);


                //Home 

                Home hmpage = new Home();
                hmpage.navigateToCS(driver);
            }

        [Test]
        public void createTM()
        {
            //createTm
            customer csobj = new customer();
            csobj.createCS(driver);





        }



        }


    
}





