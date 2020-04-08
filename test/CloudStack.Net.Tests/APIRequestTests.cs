using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace CloudStack.Net.Tests
{
    [TestClass]
    public partial class APIRequestTests
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
            request.Parameters.ShouldNotContainKey(nameof(request.HostTags).ToLower());
            _ = request.HostTags.Count;
            request.Parameters.ShouldContainKey(nameof(request.HostTags).ToLower());
        }
    }
}