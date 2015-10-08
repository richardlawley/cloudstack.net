using System;

namespace CloudStack.Net
{
    public enum State
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
