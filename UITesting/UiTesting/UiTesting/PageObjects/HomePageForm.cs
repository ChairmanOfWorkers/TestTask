using System;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class HomePageForm:Form
    {
        public  HomePageForm() : base(By.XPath("//button[@class='start__button']"), "home page logo")
        {
        }
    }
}
