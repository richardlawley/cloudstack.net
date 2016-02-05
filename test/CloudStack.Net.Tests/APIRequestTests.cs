using System.Collections.Generic;
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
            var request = new TestRequest();
            request.Command.ShouldBe(TestRequest.COMMANDNAME);
            request.Parameters["command"].ShouldBe(TestRequest.COMMANDNAME);
        }

        [TestMethod]
        public void GetList_CreatesListIfNotExisting()
        {
            var request = new TestRequest();
            request.Parameters.ShouldNotContainKey("TestList");

            var existingCount = request.TestList.Count;
            request.Parameters.ShouldContainKey("TestList");
        }

        public class TestRequest : APIRequest
        {
            public const string COMMANDNAME = "TestRequest";

            public TestRequest() : base(COMMANDNAME)
            {
            }

            public IList<object> TestList => GetList<object>("TestList");
        }
    }
}