using NUnit.Framework;
using TestingCA;
using TestingCAWebApp.Controllers;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
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
