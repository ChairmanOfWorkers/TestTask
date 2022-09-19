using System;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class IndexPageForm:Form
    {
        private static ILink hereLink => ElementFactory.GetLink(By.XPath("//a[@class='start__link']"), "home");
        
        public IndexPageForm():base(By.ClassName("view__content"), "index page to move to home page")
        {
        }
        
        public void PressHereLink()
        {
            hereLink.Click();
        }
    }
}
