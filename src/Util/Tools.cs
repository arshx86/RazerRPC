#region

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

#endregion

namespace RazerRPC.Util
{
    internal class Tools
    {
        public enum Effect
        {
            Roll,
            Slide,
            Center,
            Blend
        }

        private static readonly int[] dirmap =
        {
            1,
            5,
            4,
            6,
            2,
            10,
            8,
            9
        };

        private static readonly int[] effmap =
        {
            0,
            0x400000,
            0x10,
            0x80000
        };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        /// <summary>
        ///     Animates a control.
        /// </summary>
        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl is null) return;
            if (ctl.Visible)
            {
                flags |= 0x10000;
                angle += 180;
            }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }

            flags |= dirmap[angle % 360 / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            // if (!ok) throw new ArgumentException();
            ctl.Visible = !ctl.Visible;
        }

        /// <summary>
        ///     Creates registry key under Run to start RazerRPC at startup silently.
        /// </summary>
        /// <param name="enable">Whether this module enabled.</param>
        public static void PutStartup(bool enable)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (enable) rk?.SetValue("RazerRPC", $"{Application.ExecutablePath} /silent");
            else rk?.DeleteValue("RazerRPC", false);
            rk?.Close();
        }

    }
}