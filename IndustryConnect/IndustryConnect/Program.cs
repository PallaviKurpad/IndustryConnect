﻿using OpenQA.Selenium;
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