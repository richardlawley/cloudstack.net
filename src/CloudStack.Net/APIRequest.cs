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
        /// Convenience property to return the API command.
        /// </summary>
        public string Command => (string)Parameters[nameof(Command).ToLower()];

        /// <summary>
        /// Request parameters.
        /// </summary>
        public IDictionary<string, object> Parameters { get; }

        public bool SupportsImpersonation { get; }

        protected IList<T> GetList<T>(string name)
        {
            if (!Parameters.ContainsKey(name))
            {
                var list = new List<T>();
                Parameters[name] = list;
            }
            return (IList<T>)Parameters[name];
        }

        protected T GetParameterValue<T>(string key)
        {
            if (!Parameters.ContainsKey(key))
            {
                return default(T);
            }

            return (T)Parameters[key];
        }

        protected void SetParameterValue<T>(string key, T value)
        {
            Parameters[key] = value;
        }
    }
}