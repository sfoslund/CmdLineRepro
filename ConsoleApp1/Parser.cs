// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CommandLine;
using System.CommandLine.Builder;

namespace Microsoft.DotNet.Cli
{
    public static class Parser
    {
        public static readonly RootCommand RootCommand = new RootCommand();

        // Subcommands
        private static readonly Command[] Subcommands = new Command[]
        {
            BuildCommandParser.GetCommand()
        };

        private static Command ConfigureCommandLine(Command rootCommand)
        {
            // Add subcommands
            foreach (var subcommand in Subcommands)
            {
                rootCommand.AddCommand(subcommand);
            }

            return rootCommand;
        }

        public static System.CommandLine.Parsing.Parser Instance { get; } = new CommandLineBuilder(ConfigureCommandLine(RootCommand))
            .UseHelp()
            .Build();

    }
}
