namespace StringBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public static class StrtingBuilderExtensions
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            string result = "";
            string text = str.ToString();

            if (text.Length < length || startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }

            for (int i = startIndex; i <= length; i++)
            {
                result += str[i];
            }

            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder str, string textToReplace)
        {
            str.Replace(textToReplace, "");
            return str;
        }
        public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                str.Append(item);
            }

            return str;
        }
    }
}
