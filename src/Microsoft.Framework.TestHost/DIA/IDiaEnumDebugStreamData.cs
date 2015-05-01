// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace dia2
{
    [DefaultMember("Item"), Guid("486943E8-D187-4A6B-A3C4-291259FFF60D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IDiaEnumDebugStreamData
    {
        [DispId(1)]
        int count
        {

            get;
        }
        [DispId(2)]
        string name
        {

            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IEnumerator GetEnumerator();

        void Item([In] uint index, [In] uint cbData, out uint pcbData, out byte pbData);

        void Next([In] uint celt, [In] uint cbData, out uint pcbData, out byte pbData, out uint pceltFetched);

        void Skip([In] uint celt);

        void Reset();

        void Clone([MarshalAs(UnmanagedType.Interface)] out IDiaEnumDebugStreamData ppenum);
    }
}
