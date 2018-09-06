using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tnix.API
{
    public class ClientServer : IDisposable
    {
        private Process _process;

        /// <summary>
        /// Runs the client server using npm run vs-client, which runs webpack-dev-server on port 8080.
        /// </summary>
        public void Start(string path)
        {
            // Command line is npm start
            var processStartInfo = new ProcessStartInfo("npm", "start");

            processStartInfo.WorkingDirectory = path;
            processStartInfo.UseShellExecute = true;

            _process = Process.Start(processStartInfo);
        }

        public void Dispose()
        {
            //_process?.Kill();
            _process?.Dispose();
        }
    }
}
