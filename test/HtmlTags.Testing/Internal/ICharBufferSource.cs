﻿#if NETCOREAPP3_0
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers
{
    internal interface ICharBufferSource
    {
        char[] Rent(int bufferSize);

        void Return(char[] buffer);
    }
}
#endif