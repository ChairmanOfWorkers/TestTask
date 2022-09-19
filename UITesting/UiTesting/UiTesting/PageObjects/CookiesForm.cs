using System;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class CookiesForm:Form
    {
        private static ILabel cookiesForm => ElementFactory.GetLabel(By.XPath("//div[@class='cookies']"), "cookies form");
        private static IButton cookiesFormCloseBtn => ElementFactory.GetButton(By.XPath("//button[contains(@class,'button button--solid button--transparent')]"), "close cookies form button");

        public CookiesForm():base(By.XPath("//div[@class='cookies']"), "cookies form")
        {
        }

        public void PressCookiesFormCloseBtn()
        {
            cookiesForm.State.WaitForExist();
            cookiesFormCloseBtn.Click();
        }
    }
}
