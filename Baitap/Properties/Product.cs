using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProduct.DTO
{
    public class Product
    {

        public Product()
        {
            id = 1;
            name = "abc";
            price = 30000;
            image = "cba";
            desc = 1;
            qty = 9;
        }


        public Product(int id, string name, int price, string image, int desc, int qty, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.image = image;
            this.desc = desc;
            this.qty = qty;
            this.gallery = gallery;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string image { get; set; }
        public int desc { get; set; }
        public int qty { get; set; }
        List<string> gallery = new List<string>();


        public void ShowInfo()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Ten SP: " + name);
            Console.WriteLine("Gia: " + price);
            Console.WriteLine("Anh: " + image);
            Console.WriteLine("Giam dan: " + desc);
            Console.WriteLine("So luong: " + qty);
            Console.WriteLine("Bo suu tap: " + gallery);

        }

        public void CheckQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("In stock");

            }
            Console.WriteLine("Out of stock");
        }

        public bool AddImage(string i)
        {
            if (gallery.Count >= 10)
            {

                Console.WriteLine("Qua 10 anh vui long xoa bot");
                return false;
            }
            else
            {
                gallery.Add(i);
                var b = gallery.Count();
                Console.WriteLine("So anh trong list gallery la {0}", b);
                var nameImageinGallery = gallery.ToArray();
                for (int q = 0; q < nameImageinGallery.Count(); q++)
                {
                    Console.WriteLine("Phan tu thu {0} trong mang? ten image : {1}", q, nameImageinGallery[q]);
                }
                return true;

            }

        }

        public bool RemoveImage(string i)
        {

            gallery.Remove(i);
            Console.WriteLine("da xoa anh");
            return true;
        }
    }
}