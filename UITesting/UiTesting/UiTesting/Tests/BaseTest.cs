using System;
using System.Collections.Generic;
using System.Text;
using UiTesting.Utils;
using NUnit.Framework;
using Aquality.Selenium.Browsers;

namespace UiTesting.Tests
{
    public abstract class BaseTest
    {        

        [SetUp]
        static public void BeforeTest()
        {
            string url = TestDataUtils.JsonReader().Url;
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(url);
        }

        [TearDown]
        static public void AfterTest()
        {
            var browser = AqualityServices.Browser;
            browser.Quit();
        }
    }
}
