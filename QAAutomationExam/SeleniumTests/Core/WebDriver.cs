using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace StabilizeTestsDemos.ThirdVersion
{
    public class WebDriver
    {
        private IWebDriver _webDriver;
        private WebDriverWait _webDriverWait;

        public IWebDriver WrappedDriver => _webDriver;

        public object Driver { get; private set; }

        public  void Start(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    _webDriver = new ChromeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Firefox:
                    _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Edge:
                    _webDriver = new EdgeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Opera:
                    _webDriver = new OperaDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Safari:
                    _webDriver = new SafariDriver(Environment.CurrentDirectory);
                    break;
                case Browser.InternetExplorer:
                    _webDriver = new InternetExplorerDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
        }

        public void Quit()
        {
            _webDriver.Quit();
        }

        public WebElement FindElement(By locator)
        {
            IWebElement nativeWebElement =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            WebElement element = new WebElement(_webDriver, nativeWebElement, locator);

            return element;
        }

        public WebElement FindExistingElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            WebElement element = new WebElement(WrappedDriver, nativeWebElement, locator);

            return element;
        }

        public WebElement FindClickableElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            WebElement element = new WebElement(WrappedDriver, nativeWebElement, locator);

            return element;
        }

        public WebElement FindVisibleElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            WebElement element = new WebElement(WrappedDriver, nativeWebElement, locator);

            return element;
        }

        public List<WebElement> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> nativeWebElements =
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<WebElement>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                WebElement element = new WebElement(_webDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }

        public void Navigate(string url)
        {
            WrappedDriver.Navigate().GoToUrl(url);
        }

        public void TakeScreenshot()
        {
            string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
            var screenshot = ((ITakesScreenshot)WrappedDriver).GetScreenshot();
            screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
        }

        public void ScrollUp(int offset)
        {
            ((IJavaScriptExecutor)WrappedDriver).ExecuteScript($"window.scrollBy(0, -{offset});");
        }

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WrappedDriver;
            WebDriverWait wait = new WebDriverWait(WrappedDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
