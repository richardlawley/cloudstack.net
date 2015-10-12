using System;

namespace CloudStack.Net
{
    public enum VirtualMachineState
    {
        Starting,
        Running,
        Stopping,
        Stopped,
        Destroyed,
        Expunging,
        Migrating,
        Error,
        Unknown,
        Shutdowned,
    }
}
