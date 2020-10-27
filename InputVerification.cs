namespace Plutus
{
    class InputVerification
    {
        public string VerifyData(string name = "undefined", string amount = "0", string category = "undefined")
        {
            if (string.IsNullOrEmpty(name)) return "Name cannot be empty!";
            if (!double.TryParse(amount, out _)) return "Amount is not a number!";
            if (string.IsNullOrEmpty(category)) return "Please choose a category!";

            return "";
        }
    }
}