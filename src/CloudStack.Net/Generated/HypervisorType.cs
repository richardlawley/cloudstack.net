using System;

namespace CloudStack.Net
{
    public enum HypervisorType
    {
        None,
        XenServer,
        KVM,
        VMware,
        Hyperv,
        VirtualBox,
        Parralels,
        BareMetal,
        Simulator,
        Ovm,
        Ovm3,
        LXC,
        Any,
    }
}
