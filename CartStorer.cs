using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Plutus
{
    class CartStorer
    {

        CartDataParser parser = new CartDataParser();
        private static readonly string cartFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Carts/");

        string[] filePaths = Directory.GetFiles(cartFolder, "*.txt",
                                SearchOption.TopDirectoryOnly);
        public void StoreCart(Cart cart)
        {
            var name = cart.GiveName();
            var cartLoc = cartFolder + name + ".txt";
            if (File.Exists(cartLoc)) ChangeCart(cart, cartLoc);
            else CreateCart(cartLoc);
        }

        public int GiveCartCount()
        {
            var count = Directory.GetFiles(cartFolder, "*", SearchOption.TopDirectoryOnly).Length;
            return count;
        }

        public Cart LoadCart(int index)
        {

            var file = new StreamReader(filePaths[index]);
            var temp = filePaths[index].Split('/');
            var temp1 = temp[temp.Length - 1].Split('.');
            var name = temp1[0];
            var cart = new Cart(name);
            string expenseData;
            CartExpense expense;

            while ((expenseData = file.ReadLine()) != null)
            {
                expense = parser.LoadExpense(expenseData);
                cart.AddExpense(expense);
            }

            file.Close();

            return cart;
        }

        public void RenameCart(Cart cart, string newname)
        {
            var name = cart.GiveName();
            var cartLoc = cartFolder + name + ".txt";

            var newCartLoc = cartFolder + newname + ".txt";
            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(cartLoc, (newname + ".txt"));
        }

        public void DeleteCart(string name)
        {
            var cartLoc = cartFolder + name + ".txt";
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
                    writer.WriteLine(parser.SaveExpense(cart.GiveExpense(i)));
                }
            }
        }
    }
}
