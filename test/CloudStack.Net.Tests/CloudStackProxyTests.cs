using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace CloudStack.Net.Tests
{
    [TestClass]
    public class CloudStackAPIProxy_Tests
    {
        private ICloudStackAPIProxy _sut;

        [TestInitialize]
        public void _Setup()
        {
            _sut = new CloudStackAPIProxy("http://localhost:8080/client/api", "foo", "foo");
        }

        [TestMethod]
        public void CalcSignature_CorrectlyCalculatesSignature()
        {
            // Example taken from the CloudStack documentation example
            const string input = "apikey=plgwjfzk4gys3momtvmjuvg-x-jlwlnfauj9gabbbf9edm-kaymmailqzzq1elzlyq_u38zcm0bewzgudp66mg&command=listusers&response=json";
            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";
            const string expected = "TTpdDq/7j/J58XCRHomKoQXEQds=";

            string signature = CloudStackAPIProxy.CalcSignature(input, key);
            signature.ShouldBe(expected);
        }

        [TestMethod]
        public void CalcSignature_CorrectlyEncodesSignature()
        {
            // This results in a signature containing '+'.  This will be encoded when the query string is calculated

            const string input = "apikey=i-mcqzbmwigid0sohwvjk60pwxwmfc1wsenvzy1zpuou1ay-c66elwlnabeb5ylpf1f_uu_1peytzobumnll8g&command=listzones&response=json";
            const string key = "bezaSxCEjrWxutJzRdJTStGl4nEWVUDx4YX9Q8DJo6kBiUXWfdq7P8z46zaWbQBeVMTu0YiP9tVbsjbG4QFV3g";
            const string expected = "RNlqbyJYiXMGYXI5g7+0zB6Y+5w=";     // Un-encoded form: RNlqbyJYiXMGYXI5g7+0zB6Y+5w=

            string signature = CloudStackAPIProxy.CalcSignature(input, key);
            signature.ShouldBe(expected);
        }

        [TestMethod]
        public void CalcSignature_IgnoresCase()
        {
            // Example taken from the CloudStack documentation example
            const string input = "apiKey=plgwjfzk4gys3momtvmjuvg-x-jlwlnfauj9gabbbf9edm-kaymmailqzzq1elzlyq_u38zcm0bewzgudp66mg&command=listUsers&response=json";
            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";

            string signature1 = CloudStackAPIProxy.CalcSignature(input, key);
            string signature2 = CloudStackAPIProxy.CalcSignature(input.ToLower(), key);

            signature2.ShouldBe(signature1, "CalcSignature did not internally perform ToLower");
        }

        [TestMethod]
        public void CreateQuery_IgnoresEmptyLists()
        {
            const string apiKey = "plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg";

            var arguments = new Dictionary<string, object>
            {
                { "response", "json" },
                { "command", "listusers" },
                { "list", null }
            };

            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";
            const string expected = "apikey=plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg&command=listusers&response=json&signature=TTpdDq%2F7j%2FJ58XCRHomKoQXEQds%3D";

            string completeRequest = CloudStackAPIProxy.CreateQuery(arguments, apiKey, key, null);
            completeRequest.ShouldBe(expected);
        }

        [TestMethod]
        public void CreateQuery_IgnoresNullLists()
        {
            const string apiKey = "plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg";

            var request = new TestRequest();

            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";

            string completeRequest = CloudStackAPIProxy.CreateQuery(request.Parameters, apiKey, key, null);
            
            completeRequest.ShouldNotContain("hosttags");
        }

        [TestMethod]
        public void CreateQuery_IncludesEmptyLists()
        {
            const string apiKey = "plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg";

            var request = new TestRequest();
            request.HostTags = new List<string>();

            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";

            string completeRequest = CloudStackAPIProxy.CreateQuery(request.Parameters, apiKey, key, null);

            completeRequest.ShouldContain("hosttags");
        }

        [TestMethod]
        public void CreateQuery_IncludesRequestedEmptyLists()
        {
            const string apiKey = "plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg";

            var arguments = new Dictionary<string, object>
            {
                { "response", "json" },
                { "command", "listusers" },
                { "list", new List<string>() }
            };

            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";
            const string expected = "apikey=plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg&command=listusers&list=&response=json&signature=jM1%2F%2FBntxGWasZKnDDDvC8AowsE%3D";

            string completeRequest = CloudStackAPIProxy.CreateQuery(arguments, apiKey, key, null);
            completeRequest.ShouldBe(expected);
        }

        [TestMethod]
        public void CreateQuery_WithSecretKey_CorrectlyBuildsQuery()
        {
            const string apiKey = "plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg";

            var arguments = new Dictionary<string, object>
            {
                { "response", "json" },
                { "command", "listusers" }
            };

            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";
            const string expected = "apikey=plgWJfZK4gyS3mOMTVmjUVg-X-jlWlnfaUJ9GAbBbf9EdM-kAYMmAiLqzzq1ElZLYq_u38zCm0bewzGUdP66mg&command=listusers&response=json&signature=TTpdDq%2F7j%2FJ58XCRHomKoQXEQds%3D";

            string completeRequest = CloudStackAPIProxy.CreateQuery(arguments, apiKey, key, null);
            completeRequest.ShouldBe(expected);
        }

        [TestMethod]
        public void CreateQuery_WithSessionKey_CorrectlyBuildsQuery()
        {
            var arguments = new Dictionary<string, object>
            {
                { "response", "json" },
                { "command", "listusers" }
            };

            const string sessionKey = "foo";
            const string expected = "command=listusers&response=json&sessionkey=" + sessionKey;

            string completeRequest = CloudStackAPIProxy.CreateQuery(arguments, null, null, sessionKey);
            completeRequest.ShouldBe(expected);
        }

        [TestMethod]
        public void DecodeAsyncResponse_WithBody_CorrectlyDeserializesInner()
        {
            const string input = "{\"queryasyncjobresultresponse\":{\"accountid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"userid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"cmd\":\"org.apache.cloudstack.api.command.admin.vm.DeployVMCmdByAdmin\",\"jobstatus\":1,\"jobprocstatus\":0,\"jobresultcode\":0,\"jobresulttype\":\"object\",\"jobresult\":{\"virtualmachine\":{\"id\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"name\":\"VM-aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"displayname\":\"VM-aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"account\":\"testaccount\",\"userid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"username\":\"testaccount\",\"domainid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"domain\":\"ROOT\",\"created\":\"2016-04-29T14:28:36+0100\",\"state\":\"Running\",\"haenable\":true,\"zoneid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"zonename\":\"testzone\",\"hostid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"hostname\":\"testhostname\",\"templateid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"templatename\":\"CentOS\",\"templatedisplaytext\":\"CentOS\",\"passwordenabled\":true,\"serviceofferingid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"serviceofferingname\":\"testso\",\"cpunumber\":1,\"cpuspeed\":2000,\"memory\":512,\"guestosid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[],\"password\":\"xxxxxxxx\",\"nic\":[{\"id\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"networkid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"networkname\":\"test-net\",\"netmask\":\"255.255.255.0\",\"gateway\":\"10.1.1.1\",\"ipaddress\":\"10.1.1.88\",\"isolationuri\":\"vlan://1590\",\"broadcasturi\":\"vlan://1590\",\"traffictype\":\"Guest\",\"type\":\"Isolated\",\"isdefault\":true,\"macaddress\":\"02:00:7f:d7:00:01\",\"secondaryip\":[]}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-11-1111-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver61\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":123,\"jobid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"jobstatus\":0}},\"jobinstancetype\":\"VirtualMachine\",\"jobinstanceid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\",\"created\":\"2016-04-29T14:28:37+0100\",\"jobid\":\"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa\"}}";
            AsyncJobResponse response = CloudStackAPIProxy.DecodeResponse<AsyncJobResponse>(input);
            UserVmResponse resp = response.DecodeJobResult<UserVmResponse>();
            resp.ShouldNotBeNull();
            resp.UserName.ShouldBe("testaccount");
            resp.Password.ShouldBe("xxxxxxxx");
        }

        [TestMethod]
        public void DecodeCreateDomainResponse()
        {
            const string input = "{\"createdomainresponse\":{\"domain\":{\"id\":\"e2404348-5e5a-49c0-b745-8d99fb4b8aa8\",\"name\":\"Test3\",\"level\":1,\"parentdomainid\":\"4185ae78-aa09-11e5-85a8-0242ac1103ff\",\"parentdomainname\":\"ROOT\",\"haschild\":false,\"path\":\"ROOT/Test3\"}}}";
            DomainResponse response = CloudStackAPIProxy.DecodeResponse<DomainResponse>(input);

            response.Id.ShouldBe("e2404348-5e5a-49c0-b745-8d99fb4b8aa8");
            response.Name.ShouldBe("Test3");
        }

        [TestMethod]
        public void DecodeErrorResponse()
        {
            const string input = "{\"createaccountresponse\":{\"uuidList\":[],\"errorcode\":431,\"cserrorcode\":9999,\"errortext\":\"Unable to execute API command createaccount due to missing parameter password\"}}";
            APIErrorResult response = CloudStackAPIProxy.DecodeResponse<APIErrorResult>(input);

            response.ErrorText.ShouldBe("Unable to execute API command createaccount due to missing parameter password");
            response.ErrorCode.ShouldBe("431");
            response.CloudStackErrorCode.ShouldBe(9999);
        }

        [TestMethod]
        public void DecodeErrorResponse_WithUuidList()
        {
            const string input = @"{""createnetworkresponse"":{""uuidList"":[{""serialVersionUID"":-7514266713085362352,""uuid"":""d308418d-6f76-4320-920f-e362d09ac4b1"",""description"":""networkOfferingId""}],""errorcode"":431,""cserrorcode"":4350,""errortext"":""Can't use specified network offering id as its stat is not Enabled""}}";
            APIErrorResult response = CloudStackAPIProxy.DecodeResponse<APIErrorResult>(input);

            response.ErrorText.ShouldBe("Can't use specified network offering id as its stat is not Enabled");
            response.ErrorCode.ShouldBe("431");
            response.CloudStackErrorCode.ShouldBe(4350);
        }

        [TestMethod]
        public void DecodeListResponse_EmptyListResponse_InitialisesList()
        {
            const string input = "{ \"testresponse\": {} }";
            ListResponse<object> response = CloudStackAPIProxy.DecodeResponse<ListResponse<object>>(input);

            response.ShouldNotBeNull();
            response.Count.ShouldBe(0);
            response.Results.ShouldNotBeNull();
            response.Results.Count.ShouldBe(0);
        }

        [TestMethod]
        public void DecodeListResponse_PicksListElementFromResponse()
        {
            const string input = "{ \"testresponse\": { \"count\": 2, \"foolist\": [ {}, {}, {} ] } }";

            ListResponse<object> response = CloudStackAPIProxy.DecodeResponse<ListResponse<object>>(input);

            response.ShouldNotBeNull();
            response.Count.ShouldBe(2);
            response.Results.Count.ShouldBe(3);
        }

        [TestMethod]
        public void DecodeListVirtualMachinesResponse()
        {
            const string input = "{\"listvirtualmachinesresponse\":{\"count\":4,\"virtualmachine\":[{\"id\":\"88d8be12-5bd3-403e-a882-bc807a493e0f\",\"name\":\"VM-88d8be12-5bd3-403e-a882-bc807a493e0f\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:42:54+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":11,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"e5a0b488-ba92-4111-9692-4a4d653a8765\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.111\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:1c:04:00:00:21\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-7-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142},{\"id\":\"4300ed0b-48d2-48aa-ae4e-46ed0b2ede3a\",\"name\":\"VM-4300ed0b-48d2-48aa-ae4e-46ed0b2ede3a\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:41:39+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":0,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"7424f926-db26-469e-bbe5-de061cbe6524\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.142\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:4e:f6:00:00:40\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-6-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142},{\"id\":\"fa855ea7-51f3-49af-a752-76895a9df3ef\",\"name\":\"VM-fa855ea7-51f3-49af-a752-76895a9df3ef\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:41:15+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":11,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"a646e0f5-a3ce-45af-93a9-6cbbd0a92f0d\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.181\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:e1:bc:00:00:67\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-5-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142},{\"id\":\"b0a1cc24-e1e4-4bbb-b667-55329062bd72\",\"name\":\"VM-b0a1cc24-e1e4-4bbb-b667-55329062bd72\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:39:15+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":10,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"96ad1ee0-08c4-4e59-8156-4f1914d63a41\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.130\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:3b:c2:00:00:34\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-3-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142}]}}";

            ListResponse<UserVmResponse> response = CloudStackAPIProxy.DecodeResponse<ListResponse<UserVmResponse>>(input);

            response.ShouldNotBeNull();
            response.Count.ShouldBe(4);
            response.Results.Count.ShouldBe(4);
        }

        [TestMethod]
        public void Transform_CanSerialise_Guid()
        {
            CloudStackAPIProxy.Transform(new Dictionary<string, object> { { "foo", Guid.Empty } }).ShouldContainKeyAndValue("foo", "00000000-0000-0000-0000-000000000000");
        }

        [TestMethod]
        public void Transform_CanSerialise_String()
        {
            CloudStackAPIProxy.Transform(new Dictionary<string, object> { { "foo", "bar" } }).ShouldContainKeyAndValue("foo", "bar");
        }

        [TestMethod]
        public void Transform_CanSerializeList()
        {
            var list = new List<string>
            {
                "A",
                "B",
                "C D"
            };
            SortedDictionary<string, string> result = CloudStackAPIProxy.Transform(new Dictionary<string, object> { { "lst", list } });
            result.ShouldContainKeyAndValue("lst", "A,B,C D");
        }

        [TestMethod]
        public void Transform_CanSerializeMap()
        {
            var map = new List<IDictionary<string, object>>();
            var mapItem = new Dictionary<string, object>
            {
                { "A", "C" },
                { "B", "D" }
            };
            map.Add(mapItem);
            mapItem = new Dictionary<string, object>
            {
                { "A", "E" },
                { "B", "F" }
            };
            map.Add(mapItem);

            SortedDictionary<string, string> result = CloudStackAPIProxy.Transform(new Dictionary<string, object> { { "map", map } });
            result.ShouldContainKeyAndValue("map[0].A", "C");
            result.ShouldContainKeyAndValue("map[0].B", "D");
            result.ShouldContainKeyAndValue("map[1].A", "E");
            result.ShouldContainKeyAndValue("map[1].B", "F");
        }

        [TestMethod]
        public void Transform_ConvertsValuesProperly()
        {
            // https://github.com/exoscale/cs/blob/8ea5b60fb43437309efcf444fc4ad679bc5c37cb/cs/client.py#L122
            var input = new Dictionary<string, object>
            {
                { "a", 1 },
                { "b", "foo" },
                { "c", new [] {"eggs", "spam" }.ToList() },
                { "d", new Dictionary<string, object>{ { "key", "value" } } }
            };
            SortedDictionary<string, string> result = CloudStackAPIProxy.Transform(input);

            result.ShouldContainKeyAndValue("a", "1");
            result.ShouldContainKeyAndValue("b", "foo");
            result.ShouldContainKeyAndValue("c", "eggs,spam");
            result.ShouldContainKeyAndValue("d[0].key", "value");
        }

        [TestMethod]
        public void Transform_NullDoesNotInclude()
        {
            CloudStackAPIProxy.Transform(new Dictionary<string, object> { { "foo", null } }).ShouldNotContainKey("foo");
            CloudStackAPIProxy.Transform(new Dictionary<string, object> { { "foo", (bool?)null } }).ShouldNotContainKey("foo");
        }

        [TestMethod]
        public void CreateRequest_CorrectlySerialisesAllValues()
        {
            var request = new TestRequest();
            request.HostTags.Add("A");
            request.HostTags.Add("B");

            request.Details.ShouldBeEmpty();
            request.Details.Add(new Dictionary<string, object>());
            request.Details[0].Add("Foo", "Bar");
            request.Details[0].Add("Key", "Value");

            HttpWebRequest httpRequest = ((CloudStackAPIProxy)_sut).CreateRequest(request);
            string url = httpRequest.RequestUri.PathAndQuery;
            url.ShouldStartWith("/client/api");
            string query = httpRequest.RequestUri.Query;

            query.ShouldContain("hosttags=" + Uri.EscapeDataString("A,B"), Case.Sensitive);
            query.ShouldContain(Uri.EscapeDataString("details[0].Foo") + "=Bar", Case.Sensitive);
            query.ShouldContain(Uri.EscapeDataString("details[0].Key") + "=Value", Case.Sensitive);
        }
    }
}