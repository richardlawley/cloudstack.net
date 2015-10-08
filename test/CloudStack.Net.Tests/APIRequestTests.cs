using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace CloudStack.Net.Tests
{
    [TestClass]
    public class APIRequestTests
    {
        [TestMethod]
        public void Constructor_SerialisesCommandNameProperly()
        {
            TestRequest request = new TestRequest();
            request.Command.ShouldBe(TestRequest.COMMANDNAME);
            request.Parameters["command"].ShouldBe(TestRequest.COMMANDNAME);
        }

        public class TestRequest : APIRequest
        {
            public const string COMMANDNAME = "TestRequest";

            public TestRequest() : base(COMMANDNAME)
            {
            }
        }
    }
}