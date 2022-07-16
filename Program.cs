using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aritmetik_işlem_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sayi1, sayi2; //Basit Aritmetik İşlem Uygulaması
        

            Console.WriteLine("İslem Yapacaginiz 1.Sayiyi Giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            int secim; 

            Console.WriteLine("İslem Yapacaginiz 2.Sayiyi Giriniz:");
            sayi2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediginiz islemi seciniz:");

            Console.WriteLine("1-Toplama\n2-Fark\n3-Bolum\n4-Carpim\n");

            secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine(sayi1 + sayi2);
                        break;

                    case 2:
                         Console.WriteLine(sayi1 - sayi2);
                        break;

                    case 3:
                            Console.WriteLine(sayi1 / sayi2);
                        break;

                    case 4:
                        Console.WriteLine(sayi1 * sayi2);
                        break;
                    default:
                        Console.WriteLine("Seciminiz listede yok");
                        break;
                } 
            Console.ReadLine();
        }
    }
}
