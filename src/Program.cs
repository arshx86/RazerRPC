#region

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RazerRPC.Forms;

#endregion

namespace RazerRPC
{
    internal static class Program
    {
        private const int ATTACH_PARENT_PROCESS = -1;

        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);

        /// <summary>
        ///     Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Client(args));
        }
    }
}