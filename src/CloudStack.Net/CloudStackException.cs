using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;

namespace CloudStack.Net
{
    [Serializable]
    public abstract class CloudStackBaseException : Exception
    {
        public CloudStackBaseException()
        {
        }

        public CloudStackBaseException(string message) : base(message)
        {
        }

        public CloudStackBaseException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CloudStackBaseException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Exception type thrown by SDK.
    /// </summary>
    [Serializable]
    public class CloudStackException : CloudStackBaseException
    {
        /// <summary>
        /// Initializes a new instance of the CloudStackException class.
        /// </summary>
        public CloudStackException()
        {
        }

        /// <summary>
        /// For remote use only
        /// </summary>
        /// <param name="message"></param>
        [Obsolete("For remote use only")]
        public CloudStackException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CloudStackException class.
        /// </summary>
        /// <param name="context">Description of problem.</param>
        /// <param name="command">Details of command being executed at time of error.</param>
        /// <param name="apiErrorResult">Error details from API.</param>
        public CloudStackException(string context, string command, APIErrorResult apiErrorResult)
            : this(context, command, apiErrorResult, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CloudStackException class.
        /// </summary>
        /// <param name="context">Description of problem.</param>
        /// <param name="command">Details of command being executed at time of error.</param>
        /// <param name="errorCode">ErrorCode field of APIErrorResult property.</param>
        /// <param name="errorText">ErrorText field of APIErrorResult property.</param>
        public CloudStackException(string context, string command, string errorCode, string errorText)
            : this(context, command, errorCode, errorText, null)
        {
        }

        ///// <summary>
        ///// Initializes a new instance of the CloudStackException class.
        ///// </summary>
        ///// <param name="context">Description of problem.</param>
        ///// <param name="command">Details of command being executed at time of error.</param>
        ///// <param name="apiErrorResult">Error details from API.</param>
        ///// <param name="innerException">Exception causing problem.</param>
        //[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "Need property to access underlying member variable")]
        public CloudStackException(string context, string command, APIErrorResult result, Exception innerException)
            : base(result.ErrorText, innerException)
        {
            this.Context = context;
            this.Command = string.IsNullOrEmpty(command) ? string.Empty : command;
            this.ErrorResult = result;
        }

        /// <summary>
        /// Initializes a new instance of the CloudStackException class.
        /// </summary>
        /// <param name="context">Description of problem.</param>
        /// <param name="command">Details of command being executed at time of error.</param>
        /// <param name="errorCode">ErrorCode field of APIErrorResult property.</param>
        /// <param name="errorText">ErrorText field of APIErrorResult property.</param>
        /// <param name="innerException">Exception causing problem.</param>
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "Need property to access underlying member variable")]
        public CloudStackException(string context, string command, string errorCode, string errorText, Exception innerException)
            : base(errorText, innerException)
        {
            this.Context = context;
            this.Command = command ?? string.Empty;
            this.ErrorResult = new APIErrorResult
            {
                ErrorText = errorText,
                ErrorCode = errorCode
            };
        }

        /// <summary>
        /// Initializes a new instance of the CloudStackException class.
        /// </summary>
        /// <param name="info">
        /// Serialized data.
        /// </param>
        /// <param name="context">
        /// Deserialization context.
        /// </param>
        protected CloudStackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Stores fragment of command called.
        /// </summary>
        public string Context
        {
            get { return (string)this.Data[nameof(Context)]; }
            set { this.Data[nameof(Context)] = value; }
        }

        /// <summary>
        /// Stores fragment of command called.
        /// </summary>
        public string Command
        {
            get { return (string)this.Data[nameof(Command)]; }
            set { this.Data[nameof(Command)] = value; }
        }

        /// <summary>
        /// ErrorCode and ErrorText from CloudStack API.
        /// </summary>
        public APIErrorResult ErrorResult
        {
            get { return (APIErrorResult)this.Data[nameof(ErrorResult)]; }
            set { this.Data[nameof(ErrorResult)] = value; }
        }
    }

    [Serializable]
    public class CloudStackUnavailableException : CloudStackBaseException
    {
        public CloudStackUnavailableException() : base("The CloudStack Server was unavailable")
        {
        }

        public CloudStackUnavailableException(string message) : base(message)
        {
        }

        public CloudStackUnavailableException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CloudStackUnavailableException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }
}