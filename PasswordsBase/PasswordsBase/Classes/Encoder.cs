using System;
using System.Text;

namespace PasswordsBase
{
    public static class Encoder
    {
        private static StringBuilder builder = new StringBuilder();
        public static string Encode(string text)
        {
            Random rnd = new Random();
            var code = rnd.Next(10, 99);
            var line = text.ToCharArray();
            builder.Clear();
            builder.Append("ST_CODE ");
            for (int i = 0; i < line.Length; i++)
            {
                builder.Append(line[i] ^ code);
                builder.Append(" ");
            }
            builder.Append(code);
            return builder.ToString();
        }

        public static string Decode(string text)
        {
            var textCode = text.Split(' ');
            if (textCode[0] == "ST_CODE")
            {
                var code = int.Parse(textCode[textCode.Length - 1]);
                builder.Clear();
                for (int i = 1; i < textCode.Length - 1; i++)
                    builder.Append((char)(int.Parse(textCode[i]) ^ code));
                return builder.ToString();
            }
            return text;
        }
    }
}
