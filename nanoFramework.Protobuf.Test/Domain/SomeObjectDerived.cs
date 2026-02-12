// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace nanoFramework.Protobuf.Test.Domain
{
    [ProtoContract]
    [ProtoInclude("nanoFramework.Protobuf.Test.Domain.SomeObject, nanoFramework.Protobuf.Test", 10)]
    public class SomeObjectDerived : SomeObject
    {
        [ProtoMember(3)]
        public bool DerivedProperty;

        public override string AbstractProperty { get; set; } = string.Empty;

        public override string VirtualProperty { get; set; } = "I'm override base virtual property";
#if !NANOFRAMEWORK_1_0
        [ProtoMember(4)]
        [ProtoArrayElement("System.Int64")]
        public long[] ArrayProperty { get; set; } = new long[0];
#else
        public long[] ArrayProperty
        {
            [ProtoMember(4)]
            [ProtoArrayElement("System.Int64")]
            get;
            set;
        } = new long[0];
#endif
    }
}
