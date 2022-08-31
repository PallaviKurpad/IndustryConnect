using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginbutton.Click();

//check if user has logged in successfully
IWebElement helloUser = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloUser.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully, test passed");
}
else
{
    Console.WriteLine("Login failed, test failed");
}


/* Create new Time record */

// Navigate to Time & Materials page
IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

// Click on create new button
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


/* Delete Time and Material record */
IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPageButton.Click();

IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();

IAlert alert = driver.SwitchTo().Alert();
alert.Accept();
