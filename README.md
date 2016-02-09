# CloudStack.NET

## About

This is a .NET SDK for CloudStack, which takes care of the serialization and signing of CloudStack API requests. This 
project was started from [an existing SDK](https://github.com/siwater/cloudstack_dotnetsdk/network).  The existing 
project used hand-crafted Request/Response classes suitable for the requirements of the author.  This version differs 
by using auto-generated Request/Response classes, meaning that when a new version of CloudStack is released, it is 
easy to update the SDK without needing to go through the extensive [CloudStack API documentation](https://cloudstack.apache.org/api.html).

## Installation

    Install-Package CloudStack.Net

## TODO:

  * Impersonation
  * Request expiration

## Usage

	string serviceUri = "http://localhost:8080/client/api";
	string apiKey = "myapikey";
	string secretKey = "mysecretkey";

	using (ICloudStackAPIClient apiClient = new CloudStackAPIClient(serviceUri, apiKey, secretKey))
	{
		// List Virtual Machines
		var virtualMachinesResponse = apiClient.ListVirtualMachines(new ListVirtualMachinesRequest());
		foreach (var vm in virtualMachinesResponse.Results) 
		{
			Console.WriteLine("{0}: {1}", vm.Id, vm.Name);
		}
		
		// Deploy a Virtual Machines
		var deployRequest = new DeployVirtualMachineRequest
		{
			ZoneId = myZoneId,
			TemplateId = myZoneId,
			// ....
		};
		var job = apiClient.DeployVirtualMachine(deployRequest);
		UserVmResponse result;
		do 
		{
			var jobResult = apiClient.QueryAsyncResult<UserVmResponse>(new QueryAsyncResultRequest{ Id = job.jobid });
			if (jobResult.Jobstatus != 0) {
				result = jobResult.Result;
				break;
			}
		}
	}

There are also async/await versions of the requests:

    var job = await apiClient.DeployVirtualMachine(deployRequest);

Please see the [CloudStack API documentation](https://cloudstack.apache.org/api.html) for a list of all API functions.

## Credits

* Java SDK Generator based on API Documentation code within CloudStack
* Original API Request code based on https://github.com/siwater/cloudstack_dotnetsdk/network
