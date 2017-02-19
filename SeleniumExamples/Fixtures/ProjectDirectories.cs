using System;
using System.IO;

namespace SeleniumExamples.Fixtures
{
    static class ProjectDirectories
    {
        public static string GetDriversDirectory()
        {
            var testExecutionDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            return Path.Combine(testExecutionDirectory.FullName, "Dependencies");
        }

        public static string GetWebAppDirectory()
        {
            var testExecutionDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            return Path.Combine(testExecutionDirectory.Parent.Parent.Parent.FullName, "ExampleWebApp");
        }
    }
}
