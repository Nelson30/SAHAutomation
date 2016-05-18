using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ShopAtHomeAutomation
{
    public class LoginPage
    {
        //Method that sends the url to the driver
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://www.shopathome.com/");
            //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("class") == "merch-logo");
        }

        //Method that returns the credentials for login
        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }


    //Class for the credentials
    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }



        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        //Method who performs login action using selenium
        public void Login()
        {



            var signIn = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div[4]/ul/li[2]/ul/li[1]/a[1]"));
            signIn.Click();

            var loginInput = Driver.Instance.FindElement(By.Id("joinEmailTextBox"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("joinPasswordTextBox"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("joinRegButton"));
            loginButton.Click();

            var userFirstName = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div[4]/ul/li[2]/ul/li[1]/a"));
            userFirstName.Click();
        }
    }
}
