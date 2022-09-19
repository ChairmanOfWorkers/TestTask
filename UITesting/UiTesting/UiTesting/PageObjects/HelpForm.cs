using System;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class HelpForm : Form
    {
        private static ILabel helpForm => ElementFactory.GetLabel(By.XPath("//div[contains(@class,'help-form is-hidden')]"), "help form");
        private static IButton helpFormCloseBtn => ElementFactory.GetButton(By.XPath("//div[contains(@class,'align__cell u-right')]//button"), "close help form");
        
        public HelpForm() : base(By.ClassName("help-form"), "help form")
        {
        }
        
        public void PressHelpFormCloseBtn()
        {
            helpFormCloseBtn.Click();
        }
        
        public bool HelpFormClosed()
        {
            return helpForm.State.WaitForExist();
        }
    }
}
