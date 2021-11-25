using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProje
{
    public class DriverWrapper
    {
        public IWebDriver Driver { get; set; }
        public DriverWrapper(IWebDriver Driver)
        {
            this.Driver = Driver;

        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        public void GotoUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            Driver.Close();
        }

        public void Maximize()
        {
            Driver.Manage().Window.Maximize();
        }
        public EllementWrapper FindElementByXpath(string XPath)
        {
            var result = new EllementWrapper(Driver.FindElement(By.XPath(XPath)));
            return result;
        }

        public EllementWrapper FindElementBytagName(string TagName)
        {
            EllementWrapper result = new EllementWrapper(Driver.FindElement(By.TagName(TagName)));
            return result;
        }

        public EllementWrapper FindElementByClassName(string ClassName)
        {
            EllementWrapper result = new EllementWrapper(Driver.FindElement(By.ClassName(ClassName)));
            return result;
        }
        public List<EllementWrapper> FindElementsByClassName(string className)
        {
            var elements = Driver.FindElements(By.ClassName(className));
            var result = elements.Select(x => new EllementWrapper(x));
            return result.ToList();
        }
    }
}
