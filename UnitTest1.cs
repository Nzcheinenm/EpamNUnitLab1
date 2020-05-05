using Newtonsoft.Json;
using NUnit.Framework;
using NUnitTestProject1;
using RestSharp;

namespace Tests
{
    public class Tests
    {
        private string country;
        private int deaths;
        private string continent;

        [OneTimeSetUp]
        public void BeforeTest()
        {
            BeforeTest before = new BeforeTest();
            before.Setup();
            country = before.country;
            deaths = before.deaths;
            continent = before.continent;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(country,"Russia");
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(deaths > 0);
        }

        [Test]
        public void Test3()
        {
            StringAssert.Contains("Eur", continent);
        }



        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            country = null;
            deaths = 0;
            continent = null;
            System.Console.WriteLine("Тесты выполены.");
        }

    }
}