using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GBHNoteAutApp
{
    class Program
    {
        //create instance of driver
        public static IWebDriver driver = new ChromeDriver();
        //Java Script executor instance 
        public static IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

        LoginPage userlog = new LoginPage(driver);
        AppUtilities ut = new AppUtilities();

        static void Main(string[] args)
        { 
             
        }
        
        [SetUp]
        public void start()
        {
            //navigate to a website
            driver.Navigate().GoToUrl("https://gbhqatest.firebaseapp.com/");
        }

        [Test]
        public void login()
        {
            //pasing java script executor
            userlog.pressAccessBtn(js);

            //insert valid gmail account and pass
            userlog.enteCredentials("", "");
            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void Addingnote()
        {
            //pasing java script executor
            userlog.pressAccessBtn(js);

            //insert valid gmail account and pass
            userlog.enteCredentials("", "");
            System.Threading.Thread.Sleep(5000);

            
            //passing javaScriptExecutor
            ut.addNote(js);

        }

        [Test]
        public void editNote()
        {
            //Must have a note created before running this test case
            //pasing java script executor
            userlog.pressAccessBtn(js);

            //insert valid gmail account and pass
            userlog.enteCredentials("", "");
            System.Threading.Thread.Sleep(6000);

            ut.editNote(js);
            
        }

        [Test]
        public void DeleteNote()
        {
            //Delete Note
            //Must have a note created before running this test case
            //pasing java script executor
            userlog.pressAccessBtn(js);

            //insert valid gmail account and pass
            userlog.enteCredentials("", "");
            System.Threading.Thread.Sleep(6000);

            ut.deleteNote(js);
           
        }

        //LogOut
        [Test]
        public void logOut()
        {
            ut.logOut(js);
            
        }

       

        [TearDown]
        public void exit()
        {
            driver.Close();
        }
    }


}
