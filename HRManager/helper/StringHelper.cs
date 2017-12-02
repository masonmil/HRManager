using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MasonApps.HRManager.helper
{
    public static class StringHelper
    {

        public static string GetRandomString(string[] s, Random r)
        {
            if (s.Length < 1)
            {
                return null;
            }

            int min = 0;
            int max = s.Length;

            return s[RandomNumber(min, max, r)];

        }

        private static int RandomNumber(int min, int max, Random random)
        {
            return random.Next(min, max);
        }


        /// <summary>
        /// Returns everything between the start and end chars, exclusive.
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="start">The first char to find.</param>
        /// <param name="end">The end char to find.</param>
        /// <returns>The string between the start and stop chars, or an empty string if not found.</returns>
        public static string Between(string src, char start, char end)
        {
            string ret = String.Empty;
            int idxStart = src.IndexOf(start);
            if (idxStart != -1)
            {
                ++idxStart;
                int idxEnd = src.IndexOf(end, idxStart);
                if (idxEnd != -1)
                {
                    ret = src.Substring(idxStart, idxEnd - idxStart);
                }
            }

            return ret;
        }

        /// <summary>
        /// Returns the number of occurances of "find".
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="find">The search char.</param>
        /// <returns>The # of times the char occurs in the search string.</returns>
        public static int Count(string src, char find)
        {
            int ret = 0;
            foreach (char s in src)
            {
                if (s == find)
                {
                    ++ret;
                }
            }

            return ret;
        }

        /// <summary>
        /// Build a unique list of values that match a Regex pattern.
        /// </summary>
        /// <param name="source">String being searched.</param>
        /// <param name="pattern">Pattern to find.</param>
        /// <returns>List of values from source that match a Regex pattern.</returns>
        public static List<string> FindEachOccurrenceOf(string source, string pattern)
        {
            var occurrences = new List<string>();
            var regEx = new Regex(pattern, RegexOptions.Multiline);
            MatchCollection matches = regEx.Matches(source);
            foreach (Match m in matches)
            {
                if (!occurrences.Contains(m.Value))
                {
                    occurrences.Add(m.Value);
                }
            }

            return occurrences;
        }

        /// <summary>
        /// Retrieves a value by key from a UrlEncoded string.
        /// </summary>
        /// <param name="urlEncoded">UrlEncoded String</param>
        /// <param name="key">Key to retrieve value for</param>
        /// <returns>returns the value or "" if the key is not found or the value is blank</returns>
        public static string GetUrlEncodedKey(string urlEncoded, string key)
        {
            urlEncoded = "&" + urlEncoded + "&";

            int index = urlEncoded.IndexOf("&" + key + "=", StringComparison.OrdinalIgnoreCase);
            if (index < 0)
            {
                return string.Empty;
            }

            int lineStart = index + 2 + key.Length;

            int index2 = urlEncoded.IndexOf("&", lineStart, StringComparison.Ordinal);
            if (index2 < 0)
            {
                return string.Empty;
            }

            return UrlDecode(urlEncoded.Substring(lineStart, index2 - lineStart));
        }

        /// <summary>
        /// Returns whether the supplied string contains only alphanumeric characters.
        /// </summary>
        /// <param name="value">String value to test.</param>
        /// <returns>Whether the supplied string contains only alphanumeric characters.</returns>
        public static bool IsAlphaNumeric(this string value)
        {
            return Regex.Match(value.Trim(), @"^[a-zA-Z0-9]*$").Success;
        }

        /// <summary>
        /// Returns whether the supplied string represents boolean values true or false (false if null, string.Empty, "false" or "0"; true otherwise).
        /// </summary>
        /// <param name="value">String value to test.</param>
        /// <returns>Whether the supplied string represents boolean values true or false.</returns>
        public static bool IsTrue(this string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToLower() == "false" || value == "0")
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Left of the first occurance of c
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="c">Return everything to the left of this character.</param>
        /// <returns>String to the left of c, or the entire string.</returns>
        public static string LeftOf(string src, char c)
        {
            string ret = src;
            int idx = src.IndexOf(c);
            if (idx != -1)
            {
                ret = src.Substring(0, idx);
            }

            return ret;
        }

        /// <summary>
        /// Left of the n'th occurance of c.
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="c">Return everything to the left n'th occurance of this character.</param>
        /// <param name="n">The occurance.</param>
        /// <returns>String to the left of c, or the entire string if not found or n is 0.</returns>
        public static string LeftOf(string src, char c, int n)
        {
            string ret = src;
            int idx = -1;
            while (n > 0)
            {
                idx = src.IndexOf(c, idx + 1);
                if (idx == -1)
                {
                    break;
                }

                --n;
            }

            if (idx != -1)
            {
                ret = src.Substring(0, idx);
            }

            return ret;
        }

        /// <summary>
        /// Returns everything to the left of the righmost char c.
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="c">The search char.</param>
        /// <returns>Everything to the left of the rightmost char c, or the entire string.</returns>
        public static string LeftOfRightmostOf(string src, char c)
        {
            string ret = src;
            int idx = src.LastIndexOf(c);
            if (idx != -1)
            {
                ret = src.Substring(0, idx);
            }

            return ret;
        }

        /// <summary>
        /// Returns a string that is the reverse of the supplied string.
        /// </summary>
        /// <param name="s">String value to process.</param>
        /// <returns>A string that is the reverse of the supplied string.</returns>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Right of the first occurance of c
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="c">The search char.</param>
        /// <returns>Returns everything to the right of c, or an empty string if c is not found.</returns>
        public static string RightOf(string src, char c)
        {
            string ret = String.Empty;
            int idx = src.IndexOf(c);
            if (idx != -1)
            {
                ret = src.Substring(idx + 1);
            }

            return ret;
        }

        /// <summary>
        /// Right of the n'th occurance of c
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="c">The search char.</param>
        /// <param name="n">The occurance.</param>
        /// <returns>Returns everything to the right of c, or an empty string if c is not found.</returns>
        public static string RightOf(string src, char c, int n)
        {
            string ret = String.Empty;
            int idx = -1;
            while (n > 0)
            {
                idx = src.IndexOf(c, idx + 1);
                if (idx == -1)
                {
                    break;
                }

                --n;
            }

            if (idx != -1)
            {
                ret = src.Substring(idx + 1);
            }

            return ret;
        }

        /// <summary>
        /// Returns everything to the right of the rightmost char c.
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <param name="c">The seach char.</param>
        /// <returns>Returns everything to the right of the rightmost search char, or an empty string.</returns>
        public static string RightOfRightmostOf(string src, char c)
        {
            string ret = String.Empty;
            int idx = src.LastIndexOf(c);
            if (idx != -1)
            {
                ret = src.Substring(idx + 1);
            }

            return ret;
        }

        /// <summary>
        /// Returns the rightmost char in src.
        /// </summary>
        /// <param name="src">The source string.</param>
        /// <returns>The rightmost char, or '\0' if the source has zero length.</returns>
        public static char Rightmost(string src)
        {
            char c = '\0';
            if (src.Length > 0)
            {
                c = src[src.Length - 1];
            }

            return c;
        }

        /// <summary>
        /// Truncates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="length">The length.</param>
        /// <returns>Truncated string.</returns>
        public static string Truncate(string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }

            return source;
        }

        /// <summary>
        /// Truncates the specified stringbuilder source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="length">The length.</param>
        /// <returns>Truncated StringBuilder.</returns>
        public static StringBuilder TruncateSb(StringBuilder source, int length)
        {
            if (source.Length > length)
            {
                source = source.Remove(length, source.Length - length);
            }

            return source;
        }

        /// <summary>
        /// UrlDecodes a string without requiring System.Web
        /// </summary>
        /// <param name="text">String to decode.</param>
        /// <returns>decoded string</returns>
        public static string UrlDecode(string text)
        {
            // pre-process for + sign space formatting since System.Uri doesn't handle it
            // plus literals are encoded as %2b normally so this should be safe
            text = text.Replace("+", " ");
            return Uri.UnescapeDataString(text);
        }

        /// <summary>
        /// UrlEncodes a string without the requirement for System.Web
        /// </summary>
        /// <param name="text">String value to encode.</param>
        /// <returns>Encoded string value.</returns>
        ////[Obsolete("Use System.Uri.EscapeDataString instead")]
        public static string UrlEncode(string text)
        {
            // Sytem.Uri provides reliable parsing
            return Uri.EscapeDataString(text);
        }

        /// <summary>
        /// Convert the encoded characters in the supplied XML to their original values (&amp; &lt;, &gt; &quot;, &apos;).
        /// </summary>
        /// <param name="source">XML string to decode.</param>
        /// <returns>Decoded XML string.</returns>
        public static string XmlDecode(this string source)
        {
            if (source == null)
            {
                return null;
            }

            StringBuilder result = null;

            bool inToken = false;
            int tokenStart = 0;
            int lastTokenEnd = 0;

            char[] characters = source.ToCharArray();
            int length = source.Length;

            for (int characterIndex = 0; characterIndex < length; characterIndex++)
            {
                char character = characters[characterIndex];

                if (character == '&')
                {
                    inToken = true;
                    tokenStart = characterIndex;
                }
                else if (character == ';')
                {
                    if (!inToken)
                        continue;

                    inToken = false;
                    int tokenEnd = characterIndex;

                    String token = source.Substring(tokenStart, (tokenEnd - tokenStart) + 1);
                    String label = token;
                    switch (token)
                    {
                        case "&amp;":
                            label = "&";
                            break;
                        case "&lt;":
                            label = "<";
                            break;
                        case "&gt;":
                            label = ">";
                            break;
                        case "&quot;":
                            label = "\"";
                            break;
                        case "&apos;":
                            label = "'";
                            break;
                    }

                    if (result == null)
                    {
                        result = new StringBuilder(source.Length);
                    }

                    result.Append(source, lastTokenEnd, tokenStart - lastTokenEnd);
                    result.Append(label);

                    lastTokenEnd = (tokenEnd + 1);
                }
            }

            if (result != null)
            {

                if (lastTokenEnd < source.Length)
                {
                    result.Append(source, lastTokenEnd, source.Length - lastTokenEnd);
                }

                return result.ToString();
            }
            else
            {
                return source;
            }
        }

        /// <summary>
        /// Convert the special XML characters to their encoded versions (&amp; &lt;, &gt; &quot;, &apos;).
        /// </summary>
        /// <param name="source">XML string to encode.</param>
        /// <returns>Encoded XML string.</returns>
        public static string XmlEncode(this string source)
        {
            StringBuilder xmlEncoded = null;

            char[] characters = source.ToCharArray();
            int size = source.Length;
            int lastTokenEnd = 0;

            for (int charIndex = 0; charIndex < size; charIndex++)
            {
                char currentChar = characters[charIndex];

                string label = null;
                switch (currentChar)
                {
                    case '&':
                        label = "&amp;";
                        break;
                    case '<':
                        label = "&lt;";
                        break;
                    case '>':
                        label = "&gt;";
                        break;
                    case '"':
                        label = "&quot;";
                        break;
                    case '\'':
                        label = "&apos;";
                        break;
                }

                if (label != null)
                {

                    if (xmlEncoded == null)
                    {
                        xmlEncoded = new StringBuilder(size);
                    }

                    xmlEncoded.Append(source, lastTokenEnd, charIndex - lastTokenEnd);
                    xmlEncoded.Append(label);

                    lastTokenEnd = charIndex + 1;
                }
            }

            if (xmlEncoded != null)
            {
                if (lastTokenEnd < source.Length)
                {
                    xmlEncoded.Append(source, lastTokenEnd, source.Length - lastTokenEnd);
                }

                return xmlEncoded.ToString();
            }
            else
            {
                return source;
            }
        }
    }
}

