using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CharityCertificate
{
    class FillForms
    {
        public IWebDriver driver { get; set; }
        public string smail { get; set; }
        TimeSpan timeout = new TimeSpan(00, 00, 15);
        Random rand = new Random();

        public FillForms(IWebDriver driver )
        {
            this.driver = driver;
        }

        public void Action()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://new2.wwf.ru/help/certificates");
            driver.Navigate().Refresh();
            var click= (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("cil-button")));
            click.Click();
            var name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("name_to")));
            name.SendKeys("Тест");
            smail = "TestingItech";
            var email = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("email_from")));
            email.SendKeys(smail + "@send22u.info");
            email.Submit();
            var batton= (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("is-radio-selector")));
            batton.Click();
            batton.Submit();
        }
    }
}
