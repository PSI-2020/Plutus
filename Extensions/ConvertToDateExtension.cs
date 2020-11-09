using System;

namespace Plutus
{
   public static class ConvertToDateExtension
    {
        public static DateTime ConvertToDate(this int seconds) => new DateTime(1970, 1, 1).AddSeconds(seconds).ToLocalTime();
    }
}
