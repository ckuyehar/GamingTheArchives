using System;
using CommandLine;

namespace ArchiveSiteBackend.Api.Options {
    [Verb("init", HelpText = "Initialize the archive database.")]
    public class InitializeOptions : CommonOptions {
        [Option("drop", HelpText = "A flag that indicates the database should be dropped and recreated if it already exists.")]
        public Boolean DropDatabase { get; set; }

    }
}
