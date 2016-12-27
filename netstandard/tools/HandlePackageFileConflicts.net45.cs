﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Utilities;
using System;
using System.Reflection;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class HandlePackageFileConflicts : Task
    {
        private Version GetAssemblyVersion(string sourcePath)
        {
            return AssemblyName.GetAssemblyName(sourcePath)?.Version;
        }
    }
}