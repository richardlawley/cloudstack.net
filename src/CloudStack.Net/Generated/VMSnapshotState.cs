using System;

namespace CloudStack.Net
{
    public enum VMSnapshotState
    {
        Allocated,
        Creating,
        Ready,
        Reverting,
        Expunging,
        Removed,
        Error,
    }
}
