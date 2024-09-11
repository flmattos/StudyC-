using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_tests;

public class SeleniumTest 
{
    IWebDriver driver = new ChromeDriver();

    [SetUp]
    public void Init() {
        driver.Navigate().GoToUrl("https://www.selenium.dev/");
    }

    [Test]
    public void FirstTest(){
        IWebElement element = driver.FindElement(By.Id("Layer_1"));
        Assert.That(element.Displayed);
    }

    [TearDown]
    public void QuitDriver() {
        driver.Quit();
    }
}