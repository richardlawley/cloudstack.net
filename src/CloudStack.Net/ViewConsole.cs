using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CloudStack.Net
{
    public class ViewConsoleRequest : APIRequest
    {
        // client/console?cmd=access&vm=vmid

        public ViewConsoleRequest() : base("-ViewConsole-")
        {
            Parameters.Clear();
            Parameters.Add("cmd", "access");
        }

        /// <summary>
        /// the name of the physical network
        /// </summary>
        public Guid VirtualMachineId
        {
            get { return GetParameterValue<Guid>("vm"); }
            set { SetParameterValue("vm", value); }
        }

        internal override string OverrideEndpoint => "console";
        internal override bool OverrideDecodeResponse => true;
    }

    public class ViewConsoleResponse : CustomResponse
    {
        private static Regex _rxResponse = new Regex(@"^<html><title>(?<title>.+)</title><frameset><frame src=""(?<url>.*)""></frame></frameset></html>$", RegexOptions.ExplicitCapture | RegexOptions.Compiled);

        public string Name { get; set; }
        public string Url { get; set; }

        public override void DecodeResponse(string response)
        {
            Match m = _rxResponse.Match(response);
            if (!m.Success)
            {
                throw new FormatException("Console response was not of the expected format:\n\n" + response);
            }

            Name = m.Groups["name"].Value;
            Url = m.Groups["url"].Value;
        }
    }

    public partial interface ICloudStackAPIClient
    {
        ViewConsoleResponse ViewConsole(ViewConsoleRequest request);
        Task<ViewConsoleResponse> ViewConsoleAsync(ViewConsoleRequest request);
    }

    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ViewConsoleResponse ViewConsole(ViewConsoleRequest request) => Proxy.Request<ViewConsoleResponse>(request);
        public Task<ViewConsoleResponse> ViewConsoleAsync(ViewConsoleRequest request) => Proxy.RequestAsync<ViewConsoleResponse>(request);
    }
}