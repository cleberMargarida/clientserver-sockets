using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Util
    {
        public static int toInt(this string str) => Convert.ToInt32(str);

        /// <summary>
        /// Used to modify properties of an object returned from a LINQ query
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="input">The source</param>
        /// <param name="updater">The action to perform.</param>
        public static TSource Apply<TSource>(this TSource input, Action<TSource> updater)
        {
            if (updater != null && input != null)
            {
                updater(input);
            }
            return input;
        }
    }
}
