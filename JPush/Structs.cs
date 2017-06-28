using System;
using ObjCRuntime;

namespace JPush_iOS
{
    [Native]
    [Flags]
    public enum JPAuthorizationOptions : int
    {
        None = 0,
        Badge = (1 << 0),
        Sound = (1 << 1),
        Alert = (1 << 2)
    }
}
