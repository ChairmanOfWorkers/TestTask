using System;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class CardThree : Form
    {   
        public CardThree() : base(By.XPath("//div[contains(@class,'age-property')]"), "age field unique element")
        {
        }
    }
}
