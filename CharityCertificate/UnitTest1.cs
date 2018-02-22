using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace CharityCertificate
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Price()
        {
            string actual = "500.00 РУБ";

            FillForms fo = new FillForms(driver);
            fo.Action();

            PayerData fo1 = new PayerData(driver);
            fo1.Action();

            Assert.AreEqual(fo1.text, actual);
        }

    }
}
