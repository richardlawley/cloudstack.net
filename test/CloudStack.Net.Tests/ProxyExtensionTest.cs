using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shouldly;

namespace CloudStack.Net.Tests
{
    [TestClass]
    public class ProxyExtensionTest
    {
        private int _maxPageSize = 10;
        private Mock<ICloudStackAPIProxy> _proxy;
        private List<TestResponse> _results = new List<TestResponse>();

        [TestInitialize]
        public void _Setup()
        {
            InitList(35);

            _proxy = new Mock<ICloudStackAPIProxy>();

            _proxy.Setup(x => x.Request<ListResponse<TestResponse>>(It.IsAny<TestRequest>()))
                .Returns<TestRequest>(r => ListResponse<TestResponse>.CreateFromList(_results, r, _maxPageSize));
            _proxy.Setup(x => x.RequestAsync<ListResponse<TestResponse>>(It.IsAny<TestRequest>()))
                .Returns<TestRequest>(r => Task.FromResult(ListResponse<TestResponse>.CreateFromList(_results, r, _maxPageSize)));
        }

        [TestMethod]
        public void RequestAllPages_CallsProxyUntilNoMoreData()
        {
            var request = new TestRequest();
            ListResponse<TestResponse> result = _proxy.Object.RequestAllPages<TestResponse>(request);
            result.Count.ShouldBe(_results.Count);

            _proxy.Verify(x => x.Request<ListResponse<TestResponse>>(It.IsAny<TestRequest>()), Times.Exactly(4));
        }

        [TestMethod]
        public void RequestAllPages_CustomPageSize_CallsProxyUntilNoMoreData()
        {
            var request = new TestRequest { PageSize = 5 };
            ListResponse<TestResponse> result = _proxy.Object.RequestAllPages<TestResponse>(request);
            result.Count.ShouldBe(_results.Count);

            _proxy.Verify(x => x.Request<ListResponse<TestResponse>>(It.IsAny<TestRequest>()), Times.Exactly(7));
        }

        [TestMethod]
        public async Task RequestAllPagesAsync_CallsProxyUntilNoMoreData()
        {
            var request = new TestRequest();
            ListResponse<TestResponse> result = await _proxy.Object.RequestAllPagesAsync<TestResponse>(request);
            result.Count.ShouldBe(_results.Count);

            _proxy.Verify(x => x.RequestAsync<ListResponse<TestResponse>>(It.IsAny<TestRequest>()), Times.Exactly(4));
        }

        private void InitList(int count)
        {
            _results.Clear();
            for (int i = 0; i < count; i++)
            {
                _results.Add(new TestResponse { Value = i });
            }
        }

        public class TestRequest : APIListRequest
        {
            public TestRequest() : base("test")
            {
            }
        }

        public class TestResponse
        {
            public int Value { get; set; }
        }
    }
}