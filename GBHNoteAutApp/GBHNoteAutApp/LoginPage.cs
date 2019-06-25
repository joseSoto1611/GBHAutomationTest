using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBHNoteAutApp
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
     

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

       public IWebElement txtEmail => _driver.FindElement(By.Id("identifierId"));
       public IWebElement btnSiguiente => _driver.FindElement(By.XPath("//*[@id='identifierNext']/span/span"));

       public IWebElement contrasena => _driver.FindElement(By.Name("password"));
       public IWebElement btnContrasena => _driver.FindElement(By.XPath("//*[@id='passwordNext']/span/span"));



        //this method logs into the app
        public void enteCredentials (string email,string password)
        {
            txtEmail.SendKeys(email);
            btnSiguiente.Click();

            System.Threading.Thread.Sleep(2000);

            contrasena.SendKeys(password);
            btnContrasena.Click();

        }

      

        public void pressAccessBtn(IJavaScriptExecutor js)
        {
            var logingButton = js.ExecuteScript("return document.querySelector('note-app').shadowRoot.querySelector('na-login')" +
                                               ".shadowRoot.querySelector('paper-button').click()");
            System.Threading.Thread.Sleep(2000);
        }

        
           
    }
}
