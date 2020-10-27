using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Plutus
{
    class CartStorer
    {
        private static readonly string _cartFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Carts/");

        string[] _filePaths = Directory.GetFiles(_cartFolder, "*.xml",
                                SearchOption.TopDirectoryOnly);

        public CartStorer()
        {

        }
        public void StoreCart(Cart cart)
        {
            var name = cart.CartName;
            var cartLoc = _cartFolder + name + ".xml";
            if (File.Exists(cartLoc)) ChangeCart(cart, cartLoc);
            else CreateCart(cartLoc);
        }

        public int GiveCartCount()
        {
            var count = Directory.GetFiles(_cartFolder, "*.xml", SearchOption.TopDirectoryOnly).Length;
            return count;
        }

        public Cart LoadCart(int index)
        {
            var temp = _filePaths[index].Split('/');
            var temp1 = temp[temp.Length - 1].Split('.');
            var name = temp1[0];

            var serializer = new XmlSerializer(typeof(List<CartExpense>));
            List<CartExpense> list = null;
            
            try
            {
                if (!File.Exists(_filePaths[index])) return null;
                using Stream stream = File.OpenRead(_filePaths[index]);
                list = serializer.Deserialize(stream) as List<CartExpense>;
            }
            catch
            {
                list = new List<CartExpense>();
            }
            var cart = new Cart(name, list);

            return cart;
        }



        public void RenameCart(Cart cart, string newname)
        {
            var name = cart.CartName;
            var cartLoc = _cartFolder + name + ".xml";

            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(cartLoc, (newname + ".xml"));
        }

        public void DeleteCart(string name)
        {
            var cartLoc = _cartFolder + name + ".xml";
            File.Delete(cartLoc);
        }



        private void CreateCart(string loc)
        {
            using (File.Create(loc)) ;
        }

        private void ChangeCart(Cart cart, string loc)
        {
            var serializer = new XmlSerializer(typeof(List<CartExpense>));
            var list = new List<CartExpense>();

            var count = cart.GiveElementC();
            for (var i = 0; i < count; i++)
            {
                list.Add(cart.GiveElement(i));
            }
            File.WriteAllText(loc, "");
            using Stream stream = File.OpenWrite(loc);
            serializer.Serialize(stream, list);
        }
    }
}
