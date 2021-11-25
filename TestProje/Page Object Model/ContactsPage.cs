using System;
using System.Collections.Generic;
using System.Text;

namespace TestProje.Page_Object_Model
{
    public class ContactsPage : BasePage
    {

        EllementWrapper txtKontacts = WebDriver.FindElementBytagName("h1");

        public ContactsPage(DriverWrapper Driver) : base(Driver)
        {
        }

        public string GetContactsTxt()
        {
            return txtKontacts.GetText();
        }
    }
}
