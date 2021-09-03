using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Util
{
    public static class Extension
    {
        /// <summary>
        /// Split a string with new lines into Array of strings.
        /// </summary>
        /// <param name="str">String source.</param>
        /// <returns>Array final.</returns>
        public static string[] SplitLine(this string str) => str.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);

        public static string GetRequestText(this string str)
        {
            var St = str.SplitLine().FirstOrDefault();

            const string spaceSlash = " /";
            const string httpSlash = "HTTP/";
            
            int pFrom = St.IndexOf(spaceSlash) + spaceSlash.Length;
            int pTo = St.LastIndexOf(httpSlash);

            return St.Substring(pFrom, pTo - pFrom);
        }
    }
}
