using NUnit.Framework;
using Utilities;

namespace Tests
{
    [TestFixture]
    public abstract class TestBase
    {
        [SetUp]
        public virtual void Setup()
        {
            var type = "local";
            var browser = "chrome";
            var environment = "PROD";
            //Driver.Init(TestContext.Parameters["type"], TestContext.Parameters["browser"], 30);
            //Driver.Goto(Environment.Init(TestContext.Parameters["environment"]));
            Driver.Init(type, browser, 30);
            Driver.Goto(Environment.Init(environment));
        }

        [TearDown]
        public virtual void Cleanup()
        {
            Driver.Quit();
        }
    }
}