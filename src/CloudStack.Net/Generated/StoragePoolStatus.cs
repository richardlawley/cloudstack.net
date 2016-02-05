using System;

namespace CloudStack.Net
{
    public enum StoragePoolStatus
    {
        Initial,
        Initialized,
        Creating,
        Attaching,
        Up,
        PrepareForMaintenance,
        ErrorInMaintenance,
        CancelMaintenance,
        Maintenance,
        Disabled,
        Removed,
    }
}
