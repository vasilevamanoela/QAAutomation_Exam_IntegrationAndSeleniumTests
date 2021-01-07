using OpenQA.Selenium.Interactions;
using StabilizeTestsDemos.ThirdVersion;

namespace POMHomework.Tests._01GoogleSearch
{
    public class BaseTest
    {
        protected WebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
            Builder = new Actions(Driver.WrappedDriver);

            Driver.WrappedDriver.Manage().Window.Maximize();
        }
    }
}
