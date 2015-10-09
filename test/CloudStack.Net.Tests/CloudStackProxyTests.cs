using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
        public void CreateQuery_WithSecretKey_CorrectlyBuildsQuery()
        {
            const string apiKey = "plgwjfzk4gys3momtvmjuvg-x-jlwlnfauj9gabbbf9edm-kaymmailqzzq1elzlyq_u38zcm0bewzgudp66mg";

            Dictionary<string, object> arguments = new Dictionary<string, object>();
            arguments.Add("response", "json");
            arguments.Add("command", "listusers");

            const string key = "VDaACYb0LV9eNjTetIOElcVQkvJck_J_QljX_FcHRj87ZKiy0z0ty0ZsYBkoXkY9b7eq1EhwJaw7FF3akA3KBQ";
            const string expected = "apikey=plgwjfzk4gys3momtvmjuvg-x-jlwlnfauj9gabbbf9edm-kaymmailqzzq1elzlyq_u38zcm0bewzgudp66mg&command=listusers&response=json&signature=TTpdDq/7j/J58XCRHomKoQXEQds=";

            string completeRequest = CloudStackAPIProxy.CreateQuery(arguments, apiKey, key, null);
            completeRequest.ShouldBe(expected);
        }

        [TestMethod]
        public void CreateQuery_WithSessionKey_CorrectlyBuildsQuery()
        {
            var arguments = new Dictionary<string, object>();
            arguments.Add("response", "json");
            arguments.Add("command", "listusers");

            const string sessionKey = "foo";
            const string expected = "command=listusers&response=json&sessionkey=" + sessionKey;

            string completeRequest = CloudStackAPIProxy.CreateQuery(arguments, null, null, sessionKey);
            completeRequest.ShouldBe(expected);
        }

        //[TestMethod]
        //public void DecodeListVirtualMachinesResponse()
        //{
        //    const string input = "{\"listvirtualmachinesresponse\":{\"count\":4,\"virtualmachine\":[{\"id\":\"88d8be12-5bd3-403e-a882-bc807a493e0f\",\"name\":\"VM-88d8be12-5bd3-403e-a882-bc807a493e0f\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:42:54+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":11,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"e5a0b488-ba92-4111-9692-4a4d653a8765\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.111\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:1c:04:00:00:21\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-7-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142},{\"id\":\"4300ed0b-48d2-48aa-ae4e-46ed0b2ede3a\",\"name\":\"VM-4300ed0b-48d2-48aa-ae4e-46ed0b2ede3a\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:41:39+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":0,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"7424f926-db26-469e-bbe5-de061cbe6524\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.142\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:4e:f6:00:00:40\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-6-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142},{\"id\":\"fa855ea7-51f3-49af-a752-76895a9df3ef\",\"name\":\"VM-fa855ea7-51f3-49af-a752-76895a9df3ef\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:41:15+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":11,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"a646e0f5-a3ce-45af-93a9-6cbbd0a92f0d\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.181\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:e1:bc:00:00:67\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-5-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142},{\"id\":\"b0a1cc24-e1e4-4bbb-b667-55329062bd72\",\"name\":\"VM-b0a1cc24-e1e4-4bbb-b667-55329062bd72\",\"displayname\":\"Test-Generated\",\"account\":\"admin\",\"domainid\":\"9716a964-6836-11e5-8a2e-0800275dc4df\",\"domain\":\"ROOT\",\"created\":\"2015-10-01T12:39:15+0000\",\"state\":\"Running\",\"haenable\":false,\"zoneid\":\"f3830db1-31b7-4e21-8734-c03b96382f26\",\"zonename\":\"DevCloud-Basic-01\",\"hostid\":\"ad1a09c2-3fe4-42de-a50e-91391e750736\",\"hostname\":\"localhost.localdomain\",\"templateid\":\"971b85b0-6836-11e5-8a2e-0800275dc4df\",\"templatename\":\"Macchinina\",\"templatedisplaytext\":\"Macchinina\",\"passwordenabled\":false,\"serviceofferingid\":\"99513820-6836-11e5-8a2e-0800275dc4df\",\"serviceofferingname\":\"Devcloud4 offering\",\"cpunumber\":1,\"cpuspeed\":200,\"memory\":256,\"cpuused\":\"0.1%\",\"networkkbsread\":0,\"networkkbswrite\":0,\"diskkbsread\":0,\"diskkbswrite\":10,\"diskioread\":0,\"diskiowrite\":0,\"guestosid\":\"97a79f64-6836-11e5-8a2e-0800275dc4df\",\"rootdeviceid\":0,\"rootdevicetype\":\"ROOT\",\"securitygroup\":[{\"id\":\"da50a2a2-6836-11e5-8a2e-0800275dc4df\",\"name\":\"default\",\"description\":\"Default Security Group\",\"account\":\"admin\",\"ingressrule\":[],\"egressrule\":[],\"tags\":[]}],\"nic\":[{\"id\":\"96ad1ee0-08c4-4e59-8156-4f1914d63a41\",\"networkid\":\"39e2c2c1-7b15-44bf-b9b6-657ce9db970e\",\"networkname\":\"guestNetworkForBasicZone\",\"netmask\":\"255.255.255.0\",\"gateway\":\"192.168.22.5\",\"ipaddress\":\"192.168.22.130\",\"broadcasturi\":\"vlan://untagged\",\"traffictype\":\"Guest\",\"type\":\"Shared\",\"isdefault\":true,\"macaddress\":\"06:3b:c2:00:00:34\"}],\"hypervisor\":\"XenServer\",\"instancename\":\"i-2-3-VM\",\"tags\":[],\"details\":{\"hypervisortoolsversion\":\"xenserver56\"},\"affinitygroup\":[],\"displayvm\":true,\"isdynamicallyscalable\":false,\"ostypeid\":142}]}}";

        //    var response = _sut.DecodeResponse<ListVirtualMachinesResponse>(input);

        //    response.ShouldNotBeNull();
        //    response.Count.ShouldBe(4);
        //    response.VirtualMachines.Count.ShouldBe(4);
        //}

        [TestMethod]
        public void DecodeListResponse_PicksListElementFromResponse()
        {
            const string input = "{ \"testresponse\": { \"count\": 2, \"foolist\": [ {}, {}, {} ] } }";

            var response = CloudStackAPIProxy.DecodeResponse<ListResponse<object>>(input);

            response.ShouldNotBeNull();
            response.Count.ShouldBe(2);
            response.Results.Count.ShouldBe(3);
        }

        [TestMethod]
        public void SerializeResponse_CanSerializeAllUsedTypes()
        {
            BindingFlags filter = BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty;

            var baseMembers = typeof(APIRequest).GetMembers(filter).Select(mi => mi.Name);

            var requestTypes = typeof(APIRequest).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(APIRequest))).ToList();
            List<string> failures = new List<string>();
            foreach (var requestType in requestTypes)
            {
                var members = requestType.GetMembers(filter).Where(mi => !baseMembers.Contains(mi.Name)).OfType<PropertyInfo>().ToList();
                foreach (var pi in members)
                {
                    var t = pi.PropertyType;
                    if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        t = t.GetGenericArguments().Single();
                    }

                    try
                    {
                        if (t == typeof(string))
                        {
                            CloudStackAPIProxy.SerialiseValue("");
                        }
                        else
                        {
                            CloudStackAPIProxy.SerialiseValue(Activator.CreateInstance(t));
                        }

                        
                    }
                    catch (MissingMethodException ex)
                    {
                        failures.Add($"Couldn't test {requestType.Name}.{pi.Name} ({t.Name})");
                    }
                    catch (NotImplementedException)
                    {
                        failures.Add($"Unable to serialize {requestType.Name}.{pi.Name} ({t.Name})");
                    }
                }
            }

            failures.ShouldBeEmpty($"{failures.Count} properties could not be serialised\n\n{String.Join("\n", failures)}");
        }

        [TestMethod]
        public void SerializeValue_CanSerialise_String()
        {
            CloudStackAPIProxy.SerialiseValue("Foo").ShouldBe("Foo");
        }
    }
}
