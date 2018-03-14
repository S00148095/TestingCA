using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestingCA;
using TestingCAWebApp.Controllers;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        IWebDriver drive;

        [SetUp]
        public void Init()
        {
            drive = new ChromeDriver();
        }

        [Test]
        public void ChromeTest1()
        {
            drive.Navigate().GoToUrl("http://localhost:50019/");
            drive.FindElement(By.Id("gender")).SendKeys("female");
            drive.FindElement(By.Id("age")).SendKeys("17");
            drive.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeTest2()
        {
            drive.Navigate().GoToUrl("http://localhost:50019/");
            drive.FindElement(By.Id("gender")).SendKeys("female");
            drive.FindElement(By.Id("age")).SendKeys("20");
            drive.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeTest3()
        {
            drive.Navigate().GoToUrl("http://localhost:50019/");
            drive.FindElement(By.Id("gender")).SendKeys("female");
            drive.FindElement(By.Id("age")).SendKeys("31");
            drive.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeTest4()
        {
            drive.Navigate().GoToUrl("http://localhost:50019/");
            drive.FindElement(By.Id("gender")).SendKeys("male");
            drive.FindElement(By.Id("age")).SendKeys("17");
            drive.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeTest5()
        {
            drive.Navigate().GoToUrl("http://localhost:50019/");
            drive.FindElement(By.Id("gender")).SendKeys("male");
            drive.FindElement(By.Id("age")).SendKeys("17");
            drive.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }

        [TearDown]
        public void CloseBrowser()
        {
            drive.Close();
        }

        [Test]
        public void FemaleBetween18And30()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(19, "female");

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void FemaleOver30()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(31, "female");

            Assert.That(result, Is.EqualTo(3.5));
        }

        [Test]
        public void MaleBetween18And35()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(19, "male");

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void MaleOver35()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(36, "male");

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void MaleOver50()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(51, "male");

            Assert.That(result, Is.EqualTo(2.5));
        }
        [Test]
        public void FemaleOver50()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(51, "female");

            Assert.That(result, Is.EqualTo(1.75));
        }

        [Test]
        public void MaleUnder18()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(17, "male");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FemaleUnder18()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(17, "female");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void OtherGender()
        {
            var sut = new Calc();

            var result = sut.CalcPremium(18, "other");

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
