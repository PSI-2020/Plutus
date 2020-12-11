namespace Plutus.Interfaces
{
    public interface ICartFrontEndService
    {
        public void NewCart();
        public void AddExpenseToCart(IInfoHolder cih);
        public int GiveCurrentCartElemCount();
        public CartExpense GiveCurrentElemAt(int i);
        public void RemoveExpenseCurrentAt(int i);

        public void SetCurrentName(string name);
        public void AddCurrentCart();

        public string GiveCurrentName();
        public int GiveCartCount();

        public string VerifyName(string name, string prevname);

        public string GiveCartNameAt(int i);

        public void CurrentCartSet(int i);

        public void SaveCartChanges(int i);

        public void DeleteCurrent();

        public void ChargeCart();

        public Cart StartShopping();

    }
}
