using OpenQA.Selenium;

namespace IndustryConnect.Pages
{
    public class HomePage
    {
        public void goToTMPage(IWebDriver driver)
        {
            // Navigate to Time & Materials page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
