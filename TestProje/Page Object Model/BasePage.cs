using System;
using System.Collections.Generic;
using System.Text;

namespace TestProje.Page_Object_Model
{
   public class BasePage
    {
        protected static DriverWrapper WebDriver;

        public BasePage(DriverWrapper Driver)
        
        {
            WebDriver = Driver;
        }

        EllementWrapper btnKontacts => WebDriver.FindElementByXpath("(//a[@href='/ua/contacts/'])[1]");
        EllementWrapper BtnDostavka => WebDriver.FindElementByXpath("(//a[@href='/ua/payment-and-delivery/'])[1]");


        public void ClickBtnKontacts()
        {
            btnKontacts.Click();
        }

        public void ClickBtnDostavka()
        {
            BtnDostavka.Click();
        }

    }
}
