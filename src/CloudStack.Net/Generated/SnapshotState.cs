using System;

namespace CloudStack.Net
{
    public enum SnapshotState
    {
        Allocated,
        Creating,
        CreatedOnPrimary,
        BackingUp,
        BackedUp,
        Copying,
        Destroying,
        Destroyed,
        Error,
    }
}
