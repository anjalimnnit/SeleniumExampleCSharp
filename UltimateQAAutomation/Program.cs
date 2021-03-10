using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UltimateQAAutomation
{
    class Program
    {
       private  static IWebDriver _driver;
        static void Main()
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");

        }

        [Test]
        public void ExecuteTest()
        {
            TestSimpleLocators();
            TestXpathSelector();
        }
        static void TestXpathSelector()
        {
            //tagname
            var byId =_driver.FindElement(By.XPath("//a[@id=\"idExample\"]"));
        }
        static void TestSimpleLocators()
        {
            ClickOn(By.Name("button1"));
            ClickOn(By.ClassName("buttonClass"));
            ClickOn(By.LinkText("Click me using this link text!"));
            ClickOn(By.PartialLinkText("Click me using"));

            var buttons = _driver.FindElements(By.TagName("button"));
            foreach (var button in buttons)
            {
                Console.WriteLine(button.Text);
            }
        }
            
        
        static void ClickOn(By locator)
        {
            var element = _driver.FindElement(locator);
            element.Click();
            Thread.Sleep(5000);
            _driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
        }
        [TearDown]
        public void CleanUp()
        {
            _driver.Close();
        }
    }

  
}
