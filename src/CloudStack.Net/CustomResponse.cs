using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStack.Net
{
    public abstract class CustomResponse
    {
        public abstract void DecodeResponse(string response);
    }
}
