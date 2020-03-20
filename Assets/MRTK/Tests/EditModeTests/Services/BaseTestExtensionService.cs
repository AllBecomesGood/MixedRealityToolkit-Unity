﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.


namespace Microsoft.MixedReality.Toolkit.Tests.EditMode.Services
{
    /// <summary>
    /// A base class for test extension services.
    /// </summary>
    internal abstract class BaseTestExtensionService : BaseExtensionService
    {
        public BaseTestExtensionService(
            string name,
            uint priority,
            BaseMixedRealityProfile profile) : base(name, priority, profile) { }

        public override void Destroy()
        {
        }
    }
}