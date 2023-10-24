using System.Text;

namespace FilesToArray
{
    public static class ExtensionMethods
    {
        public static string Sanitize(this string i)
        {
            return i

            .Replace("/", "")
            .Replace(":", "")
            .Replace("*", "")
            .Replace("?", "")
            .Replace("\"", "")
            .Replace("<", "")
            .Replace(">", "")
            .Replace("\n", "")
            .Replace("|", "");
        }
    }
}
