namespace Plutus
{
   public static class CapitalizationExtension
    {
        public static string UppercaseFirstLetter(this string input)
        {
            if (input.Length > 0)
        {
                var array = input.ToCharArray();
                if(!char.IsUpper(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
                return new string(array);
            }

            return input;
        }
    }
}
