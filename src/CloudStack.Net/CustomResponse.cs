using System;
using System.Linq;

namespace CloudStack.Net
{
    public abstract class CustomResponse
    {
        public abstract void DecodeResponse(string response);
    }
}