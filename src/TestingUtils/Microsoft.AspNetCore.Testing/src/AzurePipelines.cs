using System;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.AspNetCore.Testing
{
    public static class AzurePipelines
    {
        // Job names end in ';' because it makes it easier to concat these into a list using a constant expression:
        //  AzurePipelines.macOS + AzurePipelines.Windows

        public const string All = "all;";
        public const string None = "none;";
    }
}
