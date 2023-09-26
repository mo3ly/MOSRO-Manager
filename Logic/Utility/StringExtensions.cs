using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSROManager
{
    public static class StringExtensions
    {
        public static string TryFormat(string str, params object[] args)
        {
            string result = null;
            try
            {
                result = string.Format(str, args);
            }
            catch { }
            return result;
        }

        public static string DumpFormat(string str, params object[] args)
        {
            var builder = new StringBuilder();
            builder.Append($"Dumping string {str}");
            int index = 0;
            foreach (var arg in args)
            {
                var typeName = arg.GetType().FullName;
                builder.Append($"Index = {index++} Type = {typeName}, Value = {arg}{Environment.NewLine}");
            }

            return builder.ToString();
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                                             .Where(x => x % 2 == 0)
                                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                                             .ToArray();
        }

        //https://stackoverflow.com/questions/378415/how-do-i-extract-text-that-lies-between-parentheses-round-brackets
        public static string GetSubstringByString(string a, string b, string c)
        {
            return c.Substring((c.IndexOf(a) + a.Length), (c.IndexOf(b) - c.IndexOf(a) - a.Length));
        }
    }
}
