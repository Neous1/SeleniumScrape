﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BotTheWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");

            //create a chroe driver
            var chromeDriver = new ChromeDriver(options);
            //navigate to a url 
            chromeDriver.Navigate().GoToUrl("https://reddit.com");



            var titles = chromeDriver.FindElementByClassName("title").ToString();
            var collector = new List<string> {titles};

            foreach (var title in collector)
            {
                Console.WriteLine(title);
            }

//            //Grab the name of input as the way to navigate to that element
//            chromeDriver.FindElementByName("q").Click();
//
//
//            //pass the string "test" to the element above
//            chromeDriver.Keyboard.SendKeys("Test");
//            //press enter
//            chromeDriver.Keyboard.SendKeys(Keys.Enter);


        }
    }
}
