using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace dnx_linux_execute
{
    public class Program
    {
        public void Main(string[] args)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "uname";
            startInfo.Arguments = "-a";
            startInfo.UseShellExecute = true;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (var process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                }
            }
            catch
            {
                throw new NotSupportedException();
            }
        }
    }
}
