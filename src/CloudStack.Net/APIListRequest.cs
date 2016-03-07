using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStack.Net
{
    public abstract class APIListRequest : APIRequest
    {
        public APIListRequest(string command) : base(command) { }

        public APIListRequest(string command, bool supportsImpersonation) : base(command, supportsImpersonation) { }

        public int? Page
        {
            get { return (int?)Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize
        {
            get { return (int?)Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }
    }
}
