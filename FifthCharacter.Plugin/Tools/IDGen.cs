using System.Security.Cryptography;
using System.Text;

namespace FifthCharacter.Plugin.Tools {
    public static class IDGen {
        /// <summary>
        /// Creates a universally unique identifier from a string using the MD5 hashing algorithm.
        /// </summary>
        /// <param name="source">The source string to generate the ID from, preferably given in the format of <c>&lt;Plugin Author&gt;.&lt;Plugin Name&gt;.&lt;Plugin Version&gt;</c></param>
        /// <returns></returns>
        public static string GetID(string source) {
            using MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(source));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in data) {
                stringBuilder.Append(b.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
