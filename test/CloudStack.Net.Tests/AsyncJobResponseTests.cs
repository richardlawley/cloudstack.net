using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


        }
    }
}
