using System;
using System.Text;

namespace GloryChanger_Commands
{
    public static class Extensions
    {
        public static string ToHexString(this byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data) sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        public static byte GetByteAtDigit(this int value, int digit, int addValue = 48)
        {
            var temp = value.ToString().PadLeft(digit, '0');
            var intValue = int.Parse(temp.Substring(temp.Length - digit, 1));
            return (byte)(intValue + addValue);
        }

        public static byte GetHexAtDigit(this int value, int digit, int addValue = 48)
        {
            var temp = value.ToString("X").PadLeft(digit, '0');
            var intValue = int.Parse(temp.Substring(temp.Length - digit, 1), System.Globalization.NumberStyles.HexNumber);
            return (byte)(intValue + addValue);
        }
    }
}
