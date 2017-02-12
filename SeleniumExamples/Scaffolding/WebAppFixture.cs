using System;
using System.Diagnostics;

namespace SeleniumExamples.Scaffolding
{
    /// <summary>
    /// Starts an IIS Express instance to run the ExampleWebApp.
    /// 
    /// Code heavily borrowed from Michael Whelan's blog post and Seleno (MIT license).
    /// - Michael Whelan's blog post http://www.michael-whelan.net/testing-mvc-application-with-iis-express-webdriver/
    /// - Seleno https://github.com/TestStack/TestStack.Seleno
    /// 
    /// This is an xUnit fixture class. Refer to https://xunit.github.io/docs/shared-context.html.
    /// </summary>
    public class WebAppFixture : IDisposable
    {
        private const int WebAppPort = 59837;

        private readonly Process _webHostProcess;

        public WebAppFixture()
        {
            var key = Environment.Is64BitOperatingSystem ? "programfiles(x86)" : "programfiles";
            var programfiles = Environment.GetEnvironmentVariable(key);

            var iisExpressStartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Normal,
                ErrorDialog = true,
                LoadUserProfile = true,
                CreateNoWindow = false,
                UseShellExecute = false,
                Arguments = String.Format("/path:\"{0}\" /port:{1}", ProjectDirectories.GetWebAppDirectory(), WebAppPort),
                FileName = string.Format("{0}\\IIS Express\\iisexpress.exe", programfiles)
            };
            _webHostProcess = Process.Start(iisExpressStartInfo);
        }

        public void Dispose()
        {
            if (_webHostProcess == null)
            {
                return;
            }

            if (!_webHostProcess.HasExited)
            {
                _webHostProcess.Kill();
            }

            _webHostProcess.Dispose();
        }
    }
}
