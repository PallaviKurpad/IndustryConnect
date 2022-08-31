using OpenQA.Selenium;

namespace IndustryConnect.Pages
{
    public class TMPage
    {
        public void createTM(IWebDriver driver)
        {// Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select "Time" option from Typecode dropdown
            IWebElement typeCodeDropdwon = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdwon.Click();

            IWebElement timeOptionOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            timeOptionOverlap.Click();
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();

            // Input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("August2022");

            // Input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("August2022");

            // Input price
            IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Check if the record created is present in the table
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "August2022")
            {
                Console.WriteLine("Time record created successfully.");
            }
            else
            {
                Console.Write("New time record hasn't been created");
            }

        }

        public void editTM(IWebDriver driver)
        {
            /* Edit Time and Material record */
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            // Select "Time" option from Typecode dropdown
            IWebElement editTypeCodeDropdwon = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            editTypeCodeDropdwon.Click();

            IWebElement editTimeOptionOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            editTimeOptionOverlap.Click();
            IWebElement editTimeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            editTimeOption.Click();

            // Input code
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("August-2022");

            // Input description
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            //editDescriptionTextbox.SendKeys("August2022");

            // Input price
            IWebElement editPriceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            editPriceInputTag.Click();

            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            editPriceTextbox.Clear();
            editPriceInputTag.Click();
            editPriceTextbox.SendKeys("15");

            // Click on Save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(3000);

        }

        public void deleteTM(IWebDriver driver)
        {
            /* Delete Time and Material record */
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

    }
}
