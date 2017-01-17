// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Stashbox.Extensions.Dependencyinjection.Specificationtests.Fakes
{
    public class ClassWithThrowingCtor
    {
        public ClassWithThrowingCtor(IFakeService service)
        {
            throw new Exception(nameof(ClassWithThrowingCtor));
        }
    }
}