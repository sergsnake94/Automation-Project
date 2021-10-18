using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestProje
{
    public class TestKlass
    {
       

        IWebDriver driver = new ChromeDriver();

        public IWebDriver Driver { get => driver; set => driver = value; }

        [SetUp]
        public void Initialize()
        {
            Driver.Navigate().GoToUrl("https://exe.ua/");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement btnKontacts = Driver.FindElement(By.XPath("(//a[@href='/ua/contacts/'])[1]"));
            btnKontacts.Click();
            IWebElement txtKontacts = Driver.FindElement(By.TagName("h1"));
            string text = txtKontacts.Text;
            Assert.AreEqual("Контакти", text, "String is not as expected");


            IWebElement BtnDostavka = Driver.FindElement(By.XPath("(//a[@href='/ua/payment-and-delivery/'])[1]"));
            BtnDostavka.Click();
            IWebElement txtDostavka = Driver.FindElement(By.XPath("//h1"));
            text = txtDostavka.Text;
            Assert.AreEqual("Доставка і оплата", text, "String is not as expected");
            


        }

        [TearDown]
        public void CleanUp()
        {
            
            //this is Sparta

        }
        [OneTimeSetUp]
        public void Precondition()
        {

            Driver.Navigate().GoToUrl("https://exe.ua/");
            Thread.Sleep(1000);
        }
      //[OneTimeTearDown]
        public void Postcondition()
        {
            Driver.Close();
        }
    }
}