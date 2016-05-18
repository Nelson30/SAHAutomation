﻿
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ShopAtHomeAutomation
{
    //Class to initialize the driver
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }



        public static void Close()
        {
            Instance.Close();
        }
    }
}
