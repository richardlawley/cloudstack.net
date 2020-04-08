using System;
using System.Collections.Generic;

namespace CloudStack.Net.Tests
{
    public class TestRequest : APIRequest
    {
        public const string COMMANDNAME = "TestRequest";

        public TestRequest() : base(COMMANDNAME)
        {
        }

        public IList<IDictionary<string, object>> Details
        {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        public IList<string> HostTags
        {
            get { return GetList<string>(nameof(HostTags).ToLower()); }
            set { SetParameterValue(nameof(HostTags).ToLower(), value); }
        }

        public Guid ZoneId
        {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }
    }
}