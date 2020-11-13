// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.CommandLine;
using System.IO;

namespace Microsoft.DotNet.Cli
{
    internal static class BuildCommandParser
    {
        public static readonly Argument SlnOrProjectArgument = new Argument<IEnumerable<FileInfo>>()
        {
            Arity = ArgumentArity.ZeroOrMore
        }.ExistingOnly();

        public static Command GetCommand()
        {
            var command = new Command("build");
            command.Add(SlnOrProjectArgument);

            return command;
        }
    }
}
