using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Plutus
{
    class CartStorer
    {

        CartDataParser _parser = new CartDataParser();
        private static readonly string _cartFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Carts/");

        string[] _filePaths = Directory.GetFiles(_cartFolder, "*.txt",
                                SearchOption.TopDirectoryOnly);
        public void StoreCart(Cart cart)
        {
            var name = cart.CartName;
            var cartLoc = _cartFolder + name + ".txt";
            if (File.Exists(cartLoc)) ChangeCart(cart, cartLoc);
            else CreateCart(cartLoc);
        }

        public int GiveCartCount()
        {
            var count = Directory.GetFiles(_cartFolder, "*", SearchOption.TopDirectoryOnly).Length;
            return count;
        }

        public Cart LoadCart(int index)
        {

            var file = new StreamReader(_filePaths[index]);
            var temp = _filePaths[index].Split('/');
            var temp1 = temp[temp.Length - 1].Split('.');
            var name = temp1[0];
            var cart = new Cart(name);
            string expenseData;
            CartExpense expense;

            while ((expenseData = file.ReadLine()) != null)
            {
                expense = _parser.LoadExpense(expenseData);
                cart.AddExpense(expense);
            }

            file.Close();

            return cart;
        }

        public void RenameCart(Cart cart, string newname)
        {
            var name = cart.CartName;
            var cartLoc = _cartFolder + name + ".txt";

            var newCartLoc = _cartFolder + newname + ".txt";
            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(cartLoc, (newname + ".txt"));
        }

        public void DeleteCart(string name)
        {
            var cartLoc = _cartFolder + name + ".txt";
            File.Delete(cartLoc);
        }



        private void CreateCart(string loc)
        {
            using (File.Create(loc)) ;
        }

        private void ChangeCart(Cart cart, string loc)
        {
            var count = cart.GiveElementC();
            using (var writer = new StreamWriter(loc))
            {
                for(var i = 0; i < count; i++)
                {
                    writer.WriteLine(_parser.SaveExpense(cart.GiveElement(i)));
                }
            }
        }
    }
}
