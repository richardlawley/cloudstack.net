using System;
using System.Linq;

namespace CloudStack.Net
{
    public abstract class APIListRequest : APIRequest
    {
        public APIListRequest(string command) : this(command, false)
        {
        }

        public APIListRequest(string command, bool supportsImpersonation)
            : base(command, supportsImpersonation)
        {
            Page = null;
            PageSize = null;
        }

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