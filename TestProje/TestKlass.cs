using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TestProje
{
    public class TestKlass
    {


        IWebDriver driver = new ChromeDriver();
        private int i;

        public IWebDriver Driver { get => driver; set => driver = value; }

        [SetUp]
        public void Initialize()
        {
            Driver.Navigate().GoToUrl("https://exe.ua/");
        }

        [Test]
        public void AddToCard()
        {

            IWebElement BtnComp = Driver.FindElement(By.XPath("(//a[@href='/ua/category/c9135/'])[2]"));
            BtnComp.Click();
            IWebElement BtnLaptop = Driver.FindElement(By.XPath("(//h4[@class='cat_name'])[1]"));
            BtnLaptop.Click();
            Thread.Sleep(10000);
            IWebElement BtnBasket = Driver.FindElement(By.XPath("(//div[@class='btn_add2cart_wrap'])[1]"));
            BtnBasket.Click();
            IWebElement BtnBs = Driver.FindElement(By.XPath("//div[@class='cart_summary']"));
            BtnBs.Click();
            IWebElement txtBasket = Driver.FindElement(By.XPath("(//a[@href='/ua/product/p368971/'])[1]"));
            string text = txtBasket.GetAttribute("title");
            Assert.AreEqual("Ноутбук Lenovo ThinkBook 15 G2 (20VG006ERA)", text, "String is not as expected");
            IWebElement BtnDel = Driver.FindElement(By.XPath("//i[@class='icon16 remove']"));
            BtnDel.Click();

            IWebElement txtPr = Driver.FindElement(By.XPath("//div[@style='padding: 15px 15px 15px 15px;']"));
            text = txtPr.Text;
            Assert.AreEqual("Кошик Ваш кошик порожній.", text, "String is not as expected");


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

            IWebElement BtnGarantia = Driver.FindElement(By.XPath("(//a[@href='/ua/warranty-and-service/'])[1]"));
            BtnGarantia.Click();
            IWebElement txtGarantia = Driver.FindElement(By.XPath("//h1"));
            text = txtGarantia.Text;
            Assert.AreEqual("Гарантія та сервіс", text, "String is not as expected");

            IWebElement BtnServ = Driver.FindElement(By.XPath("(//a[@href='/ua/certificates/'])[1]"));
            BtnServ.Click();
            IWebElement txtServ = Driver.FindElement(By.XPath("//h1"));
            text = txtServ.Text;
            Assert.AreEqual("Сертифікати", text, "String is not as expected");

            IWebElement BtnPc = Driver.FindElement(By.XPath("(//a[@href='/ua/pc-building/'])[1]"));
            BtnPc.Click();
            IWebElement txtPc = Driver.FindElement(By.XPath("//h1"));
            text = txtPc.Text;
            Assert.AreEqual("Збірка ПК", text, "String is not as expected");

        }
        [Test]
        public void ExeTest()
        {
            IWebElement BtnPckomplect = Driver.FindElement(By.XPath("(//a[@href='/ua/category/c524/'])[3]"));
            BtnPckomplect.Click();
            List<IWebElement> refCategories = driver.FindElements(By.ClassName("cat_name")).ToList();
            List<string> expectedList = new List<string>
            {
                "Відеокарти",
            "Материнські плати",
            "Оперативна пам'ять",
            "Кулери і системи охолодження",
            "Корпуси",
            "Жорсткі диски",
            "Блоки живлення",
            "Процесори",
            "Контролери, адаптери",
            "SSD накопичувачі",
            "Оптичні накопичувачі",
            "Аксесуари для моддінгу",
            "Звукові карти",
            };
            for (int i = 0; i < refCategories.Count; i++)
<<<<<<< HEAD
            {
                for (int j = 0; j < expectedList.Count; j++)
                {
                    if (i == j)
                    {
                        string elementText = refCategories[i].Text;
                        Assert.AreEqual(expectedList[j], elementText[i]);
                    }
                }
                   
            }
               
=======
                for (int j = 0; j < expectedList.Count; j++)
                    if (i == j)
                    {
                        string elementText = refCategories[i].Text;
                        Assert.AreEqual(expectedList[j], refCategories[i]);
                    }
>>>>>>> SecondTest
            Console.WriteLine("Version dva");
            if (refCategories.Count == expectedList.Count)
            {
                for (int i = 0; i < refCategories.Count; i++) ;
                string elementText = refCategories[i].Text;
                Assert.AreEqual(expectedList[i], refCategories[i]);
            }
            foreach (IWebElement element in refCategories)
            {
                string elementText = element.Text;
                Console.WriteLine(elementText);
            }
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