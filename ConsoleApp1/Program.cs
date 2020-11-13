// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CommandLine.Parsing;

namespace Microsoft.DotNet.Cli
{
    public class Program
    {
        public static int Main(string[] args)
        {
            return ProcessArgs(args);
        }

        internal static int ProcessArgs(string[] args)
        {
            var parseResult = Parser.Instance.Parse(args);
            Console.WriteLine(parseResult.Diagram());
            Console.WriteLine(string.Join(' ', parseResult.Errors));
            return 1;
        }
    }
}
