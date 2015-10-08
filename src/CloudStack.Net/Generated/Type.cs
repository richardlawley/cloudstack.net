using System;

namespace CloudStack.Net
{
    public enum Type
    {
        Storage,
        Routing,
        SecondaryStorage,
        SecondaryStorageCmdExecutor,
        ConsoleProxy,
        ExternalFirewall,
        ExternalLoadBalancer,
        ExternalVirtualSwitchSupervisor,
        PxeServer,
        BaremetalPxe,
        BaremetalDhcp,
        TrafficMonitor,
        ExternalDhcp,
        SecondaryStorageVM,
        LocalSecondaryStorage,
        L2Networking,
    }
}
