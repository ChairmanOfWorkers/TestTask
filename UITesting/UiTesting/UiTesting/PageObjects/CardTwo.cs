using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements;
using OpenQA.Selenium;
using System.Collections;

namespace UiTesting.PageObjects
{
    public class CardTwo : Form
    {        
        private static List<ICheckBox> interestsCheckBox => (List<ICheckBox>)ElementFactory.FindElements<ICheckBox>(By.XPath($"(//span[contains(@class,'checkbox small')])"));
        private static ICheckBox clearInterestsCheckBox => ElementFactory.GetCheckBox(By.XPath("(//span[contains(@class,'checkbox small')])[21]"), "clear interests checkbox");
        private static ILink profilePicLink => ElementFactory.GetLink(By.XPath("//a[@class='avatar-and-interests__upload-button']"), "prolile picture upload link");
        private static IButton nextCardBtn => ElementFactory.GetButton(By.XPath("//button[@name='button' and contains(text(),'Next')]"), "next card button");
        
        private static Random rm = new Random();

        public CardTwo() : base(By.XPath("//button[contains(@class,'avatar-and-interests__avatar-upload-button')]"), "donwload button unique element")
        {
        }
       
        public void ClickClearInterestsCheckBox()
        {
            clearInterestsCheckBox.Check();
        }

        public void ChooseInterests(int numberOfInterests)
        {           
            List<int> usedIndexes = new List<int> { 17, 20};
            for (int i=0; i < numberOfInterests;)
            {
                int index = rm.Next(0, interestsCheckBox.Count);
                if (!usedIndexes.Contains(index))
                {
                    ICheckBox interest = interestsCheckBox[index];
                    interest.Click();
                    usedIndexes.Add(index);
                    i++;
                }
                else { continue; }
            }

        }
        
        public void ClickProfilePicLink()
        {
            profilePicLink.Click();
        }
        
        public void ClickNextCardBtn()
        {
            nextCardBtn.ClickAndWait();
        }
    }
}
