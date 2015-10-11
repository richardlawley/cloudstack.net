using System;
using System.Collections.Generic;

namespace CloudStack.Net
{
    public class APIRequest
    {
        /// <summary>
        /// Initializes a new instance of the APIRequest class
        /// </summary>
        /// <param name="command">command name</param>
        /// <param name="supportsImpersonation">indicates whether impersonation is supported</param>
        public APIRequest(string command, bool supportsImpersonation)
        {
            Parameters = new Dictionary<string, object>();
            Parameters[nameof(Command).ToLower()] = command;
            Parameters["response"] = "json";
            SupportsImpersonation = supportsImpersonation;
        }

        public APIRequest(string command) : this(command, false)
        {
        }

        /// <summary>
        /// Request parameters.
        /// </summary>
        public IDictionary<string, object> Parameters { get; }

        public bool SupportsImpersonation { get; }

        /// <summary>
        /// Convenience property to return the API command.
        /// </summary>
        public string Command => (string) Parameters[nameof(Command).ToLower()];
    }
}