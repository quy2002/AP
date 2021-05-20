using ManageProduct.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProduct
{
    class Program
    {
        private static object i;

        static void Main(string[] args)
        {
            Product product = new Product();

            int choose;
            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine() ?? string.Empty);


                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Infomation Product : ");
                        product.ShowInfo();

                        break;
                    case 2:
                        Console.WriteLine("CheckQty");
                        product.CheckQty();
                        break;
                    case 3:
                        Console.WriteLine("Add Image");
                        Console.WriteLine("Nhap 1 anh:");
                        i = Console.ReadLine();
                        product.AddImage(i.ToString());
                        break;
                    case 4:
                        Console.WriteLine("4. Remove Image");
                        Console.WriteLine("Nhap 1 anh can xoa:");
                        i = Console.ReadLine();
                        product.RemoveImage(i.ToString());
                        break;
                    case 5:
                        Console.WriteLine("5. Exit ");
                        break;
                    default:
                        Console.WriteLine("Nhap khong chinh xac ( chi nhap tu 1-5)");
                        break;

                }
            } while (choose != 5);
        }

        static void ShowMenu()
        {
            Console.WriteLine("1.GetInfo");
            Console.WriteLine("2.CheckQty");
            Console.WriteLine("3.Add Image");
            Console.WriteLine("4. Remove Image");
            Console.WriteLine("5. Exit ");
            Console.Write("Choose : ");
        }
    }
}
