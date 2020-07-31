using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using StabilizeTestsDemos.ThirdVersion;
using System;

namespace POMHomework.Pages
{
    public abstract class BasePage
    {
        public WebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public Actions Builder { get; }

        public virtual string Url { get; }

        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(10));
            Builder = new Actions(Driver.WrappedDriver);
        }

        public void NavigateTo()
        {
            Driver.Navigate(Url);
        }

        
    }
}
