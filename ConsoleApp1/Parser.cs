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

        static Parser()
        {
            ConfigureCommandLine();
        }

        private static void ConfigureCommandLine()
        {
            // Add subcommands
            foreach (var subcommand in Subcommands)
            {
                RootCommand.AddCommand(subcommand);
            }
        }

        public static System.CommandLine.Parsing.Parser Instance { get; } = new CommandLineBuilder(RootCommand)
            //.UseExceptionHandler(ExceptionHandler)
            .UseHelp()
            //.UseHelpBuilder(context => new DotnetHelpBuilder(context.Console))
            //.UseValidationMessages(new CommandLineValidationMessages())
            .Build();

    }
}
