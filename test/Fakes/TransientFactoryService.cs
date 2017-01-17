// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Stashbox.Extensions.Dependencyinjection.Specificationtests.Fakes
{
    public class TransientFactoryService : IFactoryService
    {
        public IFakeService FakeService { get; set; }

        public int Value { get; set; }
    }
}