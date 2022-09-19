using Aquality.Selenium.Browsers;   
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Elements;
using NUnit.Framework;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UiTesting.Tests;
using UiTesting.PageObjects;
using UiTesting.Utils;

namespace UiTesting
{
    public class UiTest : BaseTest
    {

        [Test]
        public void FirstTestCase()
        {
            IndexPageForm indexPageForm = new IndexPageForm();
            HomePageForm homePageForm = new HomePageForm();
            CardOne cardOne = new CardOne();
            CardTwo cardTwo = new CardTwo();
            CardThree cardThree = new CardThree();

            Assert.IsTrue(homePageForm.State.IsDisplayed, "opened page is not \"Home page\"");
            indexPageForm.PressHereLink();

            Assert.IsTrue(cardOne.State.IsDisplayed, "opened card is not No1");
            cardOne.EnterPassword(Utils.EmailDataUtils.RandomPassword());
            cardOne.EnterEmail(Utils.EmailDataUtils.RandomEmailAddress());
            cardOne.EnterDomain(Utils.EmailDataUtils.RandomEmailDomain());
            cardOne.ChooseDomainEnding();
            cardOne.CheckTermsCheckBox();
            cardOne.ClickNextCardLink();

            Assert.IsTrue(cardTwo.State.IsDisplayed, "opened card is not No2");
            cardTwo.ClickClearInterestsCheckBox();
            cardTwo.ClickProfilePicLink();
            Utils.InputSimulatorUtils.UploadImage(TestDataUtils.JsonReader().ImagePath);
            cardTwo.ChooseInterests(3);
            cardTwo.ClickNextCardBtn();

            Assert.IsTrue(cardThree.State.IsDisplayed, "opened card is not No3");
        }

        [Test]
        public void SecondTestCase()
        {

            IndexPageForm indexPageForm = new IndexPageForm();
            HomePageForm homePageForm = new HomePageForm();
            HelpForm helpForm = new HelpForm();

            Assert.IsTrue(homePageForm.State.IsDisplayed, "Home Page is not opened");
            indexPageForm.PressHereLink();
            
            helpForm.PressHelpFormCloseBtn();
            Assert.IsTrue(helpForm.HelpFormClosed(), "Help Form is not opened");
        }
        
        [Test]
        public  void ThirdTestCase()
        {
            IndexPageForm indexPageForm = new IndexPageForm();
            HomePageForm homePageForm = new HomePageForm();
            CookiesForm cookiesForm = new CookiesForm();

            Assert.IsTrue(homePageForm.State.IsDisplayed, "Home Page is not opened");
            indexPageForm.PressHereLink();

            cookiesForm.PressCookiesFormCloseBtn();
            Assert.IsFalse(cookiesForm.State.IsDisplayed, "Cookies form is not closed");
        }
        
        [Test]
        public void FourthTestCase()
        {
            IndexPageForm indexPageForm = new IndexPageForm();
            HomePageForm homePageForm = new HomePageForm();
            TimerForm timerForm = new TimerForm();

            Assert.IsTrue(homePageForm.State.IsDisplayed, "Home Page is not opened");
            indexPageForm.PressHereLink();
            
            Assert.AreEqual(timerForm.GetTimerText(),"00:00:00", "timer starts not from 00:00:00");
        }
    }
}