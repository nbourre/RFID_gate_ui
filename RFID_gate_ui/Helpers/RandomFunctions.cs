using System;
using System.Linq;

namespace RFID_gate_ui.Helpers
{
    public static class RandomFunctions
    {
        private static Random random = new Random();
        public static string AlphanumericalString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
