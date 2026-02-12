// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace nanoFramework.Protobuf.Test.Domain
{
    public abstract class AbstractSomeObject
    {
#if !NANOFRAMEWORK_1_0
        public abstract string AbstractProperty { get; set; }
#else
        public abstract string AbstractProperty { get; set; }
#endif
    }
}
