using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Practice.UI_tests
{
    public class WikipediaTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-minimized");
            driver = new ChromeDriver(options);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); //явное ожидание
            //для ожидания всего на странице
            //нужно прописать в тесте
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); //неявное ожидание
            //То есть Selenium сам опрашивает элементы на видимость. Мы лишь установили насколько долго он это делает.
            //для ожидания появления элемента на странице
            //не нужно прописать в тесте
        }

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("https://ru.wikipedia.org/wiki/");
            IWebElement searchInput = driver.FindElement(By.CssSelector("[name='search']"));
            searchInput.Click();
            searchInput.SendKeys("Selenium");
            IWebElement searchIcon = driver.FindElement(By.CssSelector("#searchButton"));
            searchIcon.Click();
            Assert.That(driver.Title, Is.EqualTo("Selenium — Википедия"), "Неверный заголовок страницы");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}