#region

using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RazerRPC.Models;

#endregion

namespace RazerRPC.Util
{
    internal class IDLookup
    {
        /// <summary>
        ///     Lookups a user from their ID.
        /// </summary>
        /// <param name="ID">ID to lookup.</param>
        /// <returns>Class that contains some informations about user.</returns>
        public static DiscordUser LookupID(ulong ID)
        {
            using (var wc = new WebClient())
            {
                // Since discord dont allow the requests without authorization
                // we must generate a base64 encoded token
                wc.Headers.Add("Authorization", $"Bot {GenerateToken()}");
                string json = wc.DownloadString($"https://discord.com/api/v6/users/{ID}");
                return JsonConvert.DeserializeObject<DiscordUser>(json);
            }
        }


        /// <summary>
        ///     Generates a token to use in authorization header.
        /// </summary>
        /// <returns>A token can be used for authorization.</returns>
        private static string GenerateToken()
        {
            string tkns =
                "eyJ0b2tlbnMiOlsiT0RVeE1ETTNOVFk1TkRRNE9EQTBNelV5LllMeWNnQS5XdU1xaUR6d1lBZnBQMm9tVmM1aEZEcV9PbDQiLCJPRFV4TURRMU56a3hOREF4TVRFMU5qVTQuWUx5a0tBLmxyOEIxaXJncW15dWwyQ0t3LWNtVkhKbjdlbyIsIk9EVXhNRFExT1RFNU5qazNNREV3TmpnNC5ZTHlrUmcuZ0IwWlBhaDhtdGl2ZnBjaVRRbUdQbWdjVTBNIl19";
            string[] tokens = JsonConvert.DeserializeObject<Token>(Base64Decode(tkns)).tokens;

            return tokens[new Random().Next(0, tokens.Length)];
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private class Token
        {
            public string[] tokens { get; set; }
        }
    }
}