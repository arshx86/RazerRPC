#region

using System.Collections.Generic;
using Hardware.Info;

#endregion

namespace RazerRPC.Util
{
    internal class RazerWrapper
    {
        /*
         * why i'm gathering razer producs with WMI instead of razer chroma sdk?
         * because razer sdk or anything doesn't allow us to get products.
         * so razer sdk is sucks.
         */

        /// <summary>
        ///     A client to retrieve hardware info.
        /// </summary>
        private static readonly IHardwareInfo hwClient = new HardwareInfo();

        /// <summary>
        ///     Gets the connected razer mouses, if any.
        /// </summary>
        /// <returns>A list contains names of razer mouses.</returns>
        internal static List<string> GetMouses()
        {
            hwClient.RefreshMouseList();
            List<string> enty = new List<string>();
            foreach (var entity in hwClient.MouseList)
            {
                var desc = entity.Description;
                if (!string.IsNullOrEmpty(desc))
                    if (desc.Contains("Razer"))
                        enty.Add(desc.Replace("Razer", ""));
            }

            return enty;
        }


        /*
         *
         * SOME RAZER MOUSES DEVICES MAY SHOW AS KEYBOARD.
         *
         */
        /// <summary>
        ///     Gets the connected razer keyboards, if any.
        /// </summary>
        /// <returns>A list contains names of razer keyboards.</returns>
        internal static List<string> GetKeyboards()
        {
            hwClient.RefreshKeyboardList();
            List<string> enty = new List<string>();
            foreach (var entity in hwClient.KeyboardList)
            {
                var desc = entity.Description;
                if (!string.IsNullOrEmpty(desc))
                    if (desc.Contains("Razer"))
                        enty.Add(desc.Replace("Razer", ""));
            }

            return enty;
        }

        /// <summary>
        ///     Gets the connected razer headsets, if any.
        /// </summary>
        /// <returns>A list contains names of razer headsets.</returns>
        internal static List<string> GetHeadsets()
        {
            hwClient.RefreshSoundDeviceList();
            List<string> enty = new List<string>();
            foreach (var entity in hwClient.SoundDeviceList)
            {
                var desc = entity.Description;
                if (!string.IsNullOrEmpty(desc))
                    if (desc.Contains("Razer"))
                        enty.Add(desc.Replace("Razer", ""));
            }

            return enty;
        }
    }
}