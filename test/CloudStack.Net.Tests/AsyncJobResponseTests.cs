using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace CloudStack.Net.Tests
{
    [TestClass]
    public class AsyncJobResponseTests
    {
        [TestMethod]
        public void StoreJobResponse_StoresCorrectly()
        {
            var resp = new AsyncJobResponse();
            var inner = new UserVmResponse();
            resp.StoreJobResult(inner);

            resp.JobResult.ShouldNotBeNull();
        }
    }
}