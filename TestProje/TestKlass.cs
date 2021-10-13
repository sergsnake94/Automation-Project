using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProje
{
    public class TestKlass
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://exe.ua/");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Id("search_query"));
            element.SendKeys("chuj,pizda");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}