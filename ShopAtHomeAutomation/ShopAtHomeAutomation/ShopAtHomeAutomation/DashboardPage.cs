using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShopAtHomeAutomation
{

    public class DashboardPage
    {
        //Method to verify if user is logged checking if uses name is displayed
        public static bool IsAt
        {
            get
            {
                var user = Driver.Instance.FindElements(By.ClassName("account-user"));
                if (user.Count > 0)
                    return user[0].Text == "Test";
                return false;
            }
        }
    }
}
