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
            SetParameterValue("command", command);
            SetParameterValue("response", "json");
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
        public string Command => GetStringParameterValue("command");

        public string GetStringParameterValue(string key)
        {
            if (Parameters.ContainsKey(key) && Parameters[key] != null)
            {
                return (string) Parameters[key];
            }
            return null;
        }

        //public int? GetIntParameterValue(string key)
        //{
        //    if (Parameters.ContainsKey(key) && Parameters[key] != null)
        //    {
        //        return (int?)Int32.Parse(Parameters[key]);
        //    }
        //    return null;
        //}

        //public bool? GetBoolParameterValue(string key)
        //{
        //    if (Parameters.ContainsKey(key) && Parameters[key] != null)
        //    {
        //        return (bool?)Boolean.Parse(Parameters[key]);
        //    }
        //    return null;
        //}

        /// <summary>
        /// Set the named parameter value. If the value is null the named parameter will
        /// be removed from the collection.
        /// </summary>
        /// <param name="key">name of the parameter</param>
        /// <param name="value">value of the parameter</param>
        public void SetParameterValue(string key, object value)
        {
            if (value != null)
            {
                Parameters[key] = value.ToString();
            }
            else if (Parameters.ContainsKey(key))
            {
                Parameters.Remove(key);
            }
        }
    }
}