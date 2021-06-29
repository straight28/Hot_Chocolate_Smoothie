using System;
using System.Runtime.InteropServices;

namespace TestProject
{
    public struct CopyDataStruct
    {
        public IntPtr DataHandle;

        public uint DataCount;

        [MarshalAs(UnmanagedType.LPStr)]
        public string Data;
    }
}
