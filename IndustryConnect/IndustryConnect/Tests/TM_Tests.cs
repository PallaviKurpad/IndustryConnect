using IndustryConnect.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser
IWebDriver driver = new ChromeDriver();

LoginPage loginPage = new LoginPage();
loginPage.loginSteps(driver);

HomePage homePage = new HomePage();
homePage.goToTMPage(driver);

TMPage tmPage = new TMPage();
tmPage.createTM(driver);
tmPage.editTM(driver);
tmPage.deleteTM(driver);










