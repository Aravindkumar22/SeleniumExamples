using System.IO;
using System.Reflection;

namespace SeleniumExamples
{
    static class Scaffolding
    {
        public static string DriverDirectory
        {
            get
            {
                var binDirectory = GetBinDirectory();
                return Path.Combine(binDirectory, "Dependencies");
            }
        }

        private static string GetBinDirectory()
        {
            var testAssemblyDirectory = Path.GetDirectoryName(Assembly.GetAssembly(typeof(Scaffolding)).CodeBase);
            return TrimSchemeFromUri(testAssemblyDirectory);
        }

        // From Marc Gravell's answer http://stackoverflow.com/a/4517321
        private static string TrimSchemeFromUri(string uri)
        {
            int schemeEnd = uri.IndexOf(":");
            return uri.Substring(schemeEnd + 1)
                .TrimStart('\\');
        }
    }
}
