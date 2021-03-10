using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SkillShare
{
    class Program
    {
       private static IWebDriver _driver;
        static void Main(string[] args)
        {

    
        }
    
   
        [SetUp]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.skillshare.com/login/");

        }
        [Test]
        public static void Login()
        {
            var email = _driver.FindElement(By.Name("email"));
            email.SendKeys("anjalishah.mnnit@gmail.com");
            var password = _driver.FindElement(By.Name("password"));
            password.SendKeys("anjali");
            var button = _driver.FindElement(By.CssSelector("button[Type='button']"));
            button.Click();
            //Thread.Sleep(5000);

        }
        [TearDown]
        public void CleanUp()
        {
            _driver.Close();
        }
    }
}
