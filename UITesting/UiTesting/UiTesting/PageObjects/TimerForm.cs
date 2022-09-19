using System;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class TimerForm:Form
    {
        private static ILabel timerForm => ElementFactory.GetLabel(By.XPath("//div[contains(@class,'timer')]"), "timer form");

        public TimerForm() : base(By.XPath("//div[contains(@class,'timer timer--white timer--center')]"), "timer's form")
        {
        }

        public string GetTimerText()
        {
            return timerForm.Text;
        }
    }
}
