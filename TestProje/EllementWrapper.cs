using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProje
{
   public class EllementWrapper
    {
        IWebElement element;

        public EllementWrapper(IWebElement element)
        {
            this.element = element;
        }

        public void Click()
        {
            element.Click();
        }

        public void SendText(string text)
        {
            element.SendKeys(text);
        }

        public string GetText()
        {
            return element.Text;
        }
        public string GetAtribute(string text)
        {
            return element.GetAttribute(text);
        }

    }
}
