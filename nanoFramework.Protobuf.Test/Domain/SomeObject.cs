// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace nanoFramework.Protobuf.Test.Domain
{
    [ProtoContract]
    [ProtoInclude("nanoFramework.Protobuf.Test.Domain.SomeObjectDerived, nanoFramework.Protobuf.Test", 10)]
    public class SomeObject : AbstractSomeObject
    {
        [ProtoMember(1)]
        public string StringProperty;

        [ProtoMember(2)]
        public int IntProperty;

        [ProtoMember(10)]
        public SomeChildObject ChildObject;

        [ProtoMember(20)]
        public SomeChildObjectDerived DerivedChildObject;

#if !NANOFRAMEWORK_1_0
        [ProtoMember(3)]
        public override string AbstractProperty { get; set; } = "Override SomeObject";

        [ProtoMember(4)]
        public virtual string VirtualProperty { get; set; } = "I'm base virtual property";
#else
        public override string AbstractProperty { [ProtoMember(3)] get; [ProtoMember(3)] set; } = "Override SomeObject";

        public virtual string VirtualProperty { [ProtoMember(4)] get; [ProtoMember(4)] set; } = "I'm base virtual property";
#endif
    }
}
