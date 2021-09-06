using Newtonsoft.Json;
using System;
using System.Linq;

namespace Logic.Utilities
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

        public static T Deserialize<T>(this string json) => JsonConvert.DeserializeObject<T>(json);

        public static int toInt(this string str) => Convert.ToInt32(str);

        /// <summary>
        /// Used to modify properties of an object returned from a LINQ query
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="input">The source</param>
        /// <param name="updater">The action to perform.</param>
        public static TSource Modify<TSource>(this TSource input, Action<TSource> updater)
        {
            if (updater != null && input != null)
            {
                updater(input);
            }
            return input;
        }
    }
}
