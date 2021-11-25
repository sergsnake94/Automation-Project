using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TestProje.Page_Object_Model;

namespace TestProje
{
    public class TestKlass
    {
        DriverWrapper Driver;



        private int i;


        [SetUp]
        public void Initialize()
        {
            Driver = new DriverFactory().GetDriver("Chrome");
            Driver.GotoUrl("https://exe.ua/");
        }

        [Test]
        public void AddToCard()
        {

            EllementWrapper BtnComp = Driver.FindElementByXpath("(//a[@href='/ua/category/c9135/'])[2]");
            BtnComp.Click();
            EllementWrapper BtnLaptop = Driver.FindElementByXpath("(//h4[@class='cat_name'])[1]");
            BtnLaptop.Click();
            Thread.Sleep(10000);
            EllementWrapper BtnBasket = Driver.FindElementByXpath("(//div[@class='btn_add2cart_wrap'])[1]");
            BtnBasket.Click();
            EllementWrapper BtnBs = Driver.FindElementByXpath("//div[@class='cart_summary']");
            BtnBs.Click();
            EllementWrapper txtBasket = Driver.FindElementByXpath("(//a[@href='/ua/product/p368971/'])[1]");
            string text = txtBasket.GetAtribute("title");
            Assert.AreEqual("Ноутбук Lenovo ThinkBook 15 G2 (20VG006ERA)", text, "String is not as expected");
            EllementWrapper BtnDel = Driver.FindElementByXpath("//i[@class='icon16 remove']");
            BtnDel.Click();

            EllementWrapper txtPr = Driver.FindElementByXpath("//div[@style='padding: 15px 15px 15px 15px;']");
            text = txtPr.GetText();
            Assert.AreEqual("Кошик Ваш кошик порожній.", text, "String is not as expected");


        }

        [Test]
        public void ExecuteTest()
        {
            BasePage basePage = new BasePage(Driver);
            basePage.ClickBtnKontacts();
            //EllementWrapper txtKontacts = Driver.FindElementBytagName("h1");
            // string text = txtKontacts.GetText();
            ContactsPage contactsPage = new ContactsPage(Driver);
            string text= contactsPage.GetContactsTxt();
            Assert.AreEqual("Контакти", text, "String is not as expected");

            // EllementWrapper BtnDostavka = Driver.FindElementByXpath("(//a[@href='/ua/payment-and-delivery/'])[1]");
            // BtnDostavka.Click();
            basePage = new BasePage(Driver);
            basePage.ClickBtnDostavka();

            EllementWrapper txtDostavka = Driver.FindElementByXpath("//h1");
            text = txtDostavka.GetText();
            Assert.AreEqual("Доставка і оплата", text, "String is not as expected");

            EllementWrapper BtnGarantia = Driver.FindElementByXpath("(//a[@href='/ua/warranty-and-service/'])[1]");
            BtnGarantia.Click();
            EllementWrapper txtGarantia = Driver.FindElementByXpath("//h1");
            text = txtGarantia.GetText();
            Assert.AreEqual("Гарантія та сервіс", text, "String is not as expected");

            EllementWrapper BtnServ = Driver.FindElementByXpath("(//a[@href='/ua/certificates/'])[1]");
            BtnServ.Click();
            EllementWrapper txtServ = Driver.FindElementByXpath("//h1");
            text = txtServ.GetText();
            Assert.AreEqual("Сертифікати", text, "String is not as expected");

            EllementWrapper BtnPc = Driver.FindElementByXpath("(//a[@href='/ua/pc-building/'])[1]");
            BtnPc.Click();
            EllementWrapper txtPc = Driver.FindElementByXpath("//h1");
            text = txtPc.GetText();
            Assert.AreEqual("Збірка ПК", text, "String is not as expected");

        }
        [Test]
        public void ExeTest()
        {
            EllementWrapper BtnPckomplect = Driver.FindElementByXpath("(//a[@href='/ua/category/c524/'])[3]");
            BtnPckomplect.Click();
            List<EllementWrapper> refCategories = Driver.FindElementsByClassName("cat_name");
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

            {
                for (int j = 0; j < expectedList.Count; j++)
                {
                    if (i == j)
                    {
                        string elementText = refCategories[i].GetText();
                        Assert.AreEqual(expectedList[j], elementText[i]);
                    }
                }

            }


            for (int j = 0; j < expectedList.Count; j++)
                if (i == j)
                {
                    string elementText = refCategories[i].GetText();
                    Assert.AreEqual(expectedList[j], refCategories[i]);
                }

            Console.WriteLine("Version dva");
            if (refCategories.Count == expectedList.Count)
            {
                for (int i = 0; i < refCategories.Count; i++) ;
                string elementText = refCategories[i].GetText();
                Assert.AreEqual(expectedList[i], refCategories[i]);
            }
            foreach (EllementWrapper element in refCategories)
            {
                string elementText = element.GetText();
                Console.WriteLine(elementText);
            }

            EllementWrapper btnVideocards = Driver.FindElementByXpath("(//h4[@class='cat_name'][text()='Відеокарти']");
            btnVideocards.Click();

            var chkMakerList = new List<string> { "kolia", "Anton" };
        }



        [TearDown]
        public void CleanUp()
        {

            //this is Sparta

        }
        [OneTimeSetUp]
        public void Precondition()
        {


            Thread.Sleep(1000);
        }
        //[OneTimeTearDown]
        public void Postcondition()
        {
            Driver.Close();

        }


    }
}