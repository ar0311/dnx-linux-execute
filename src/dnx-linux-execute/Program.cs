using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace dnx_linux_execute
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "uname";
            startInfo.Arguments = "-a";

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (var process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                    return 0;
                }
            }
            catch
            {
                throw new NotSupportedException();
            }
        }
    }
}
