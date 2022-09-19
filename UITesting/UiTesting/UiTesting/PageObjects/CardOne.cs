using System;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UiTesting.PageObjects
{
    public class CardOne : Form
    { 
        private static ITextBox passwordTextBox => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Choose Password')]"), "password text box");
        private static ITextBox emailTextBox => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Your email')]"), "email text box");
        private static ITextBox domainTextBox => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Domain']"), "domain text box");
        private static IComboBox domainEndingComboBox => ElementFactory.GetComboBox(By.XPath("//div[contains(@class,'dropdown dropdown--gray')]"), "domain ending comboBox");
        private static IButton domainEndingBtn => ElementFactory.GetButton(By.XPath($"(//div[@class='dropdown__list-item'])[{Utils.EmailDataUtils.RandomEmailDomainEnding()}]"), "domain ending button");
        private static ICheckBox termsCheckBox => ElementFactory.GetCheckBox(By.XPath("//span[@class='checkbox__box']"), "terms check box");
        private static ILink nextCardLink => ElementFactory.GetLink(By.XPath("//a[@class='button--secondary']"), "link to next card");

        public CardOne() : base(By.XPath("//span[@class='checkbox__box']"), "unique element terms checkbox")
        {
        }
        
        public void EnterPassword(string password)
        {
            passwordTextBox.ClearAndType(password);
        }
        
        public void EnterEmail(string email)
        {
            emailTextBox.ClearAndType(email);
        }
        
        public void EnterDomain(string domain)
        {
            domainTextBox.ClearAndType(domain);
        }
       
        public void ChooseDomainEnding()
        {
            domainEndingComboBox.Click();
            domainEndingBtn.Click();
        }
        
        public void CheckTermsCheckBox()
        {
            termsCheckBox.Click();
        }
        
        public void ClickNextCardLink()
        {
            nextCardLink.ClickAndWait();
        }
    }
}
