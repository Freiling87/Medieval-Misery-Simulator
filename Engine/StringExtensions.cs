using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Engine
{
    public static class StringExtensions
    {
        public static string ToAscii(this string text, int codepage = 437)
        {
            byte[] stringBytes = CodePagesEncodingProvider.Instance.GetEncoding(437).GetBytes(text);
            char[] stringChars = new char[stringBytes.Length];

            for (int i = 0; i < stringBytes.Length; i++)
                stringChars[i] = (char)stringBytes[i];

            return new string(stringChars);
        }
    }
}