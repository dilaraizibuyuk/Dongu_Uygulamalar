using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {   //1-100 arasında random sayı ürettirme. girilen sayıyla random üretilen sayıyı karşılaştırıcaz. bulana kadar döngü dönecek
            
            Random rastgele = new Random();
            int rs = 0;
            int s;
             rs = rastgele.Next(1, 101);
            do
            {
                Console.WriteLine("Bir sayı giriniz:");
                 s = Convert.ToInt32(Console.ReadLine());
                if (s>rs)
                {
                    Console.WriteLine("Tuttuğunuz sayıyı azaltınız");
                   
                }
                else if (s<rs)
                {
                    Console.WriteLine("Tuttuğunuz sayıyı arttırınız");
                   
                }
                else
                    Console.WriteLine("Tebrikler sayıyı buldunuz.");

            } while (s!=rs);
            Console.ReadLine();
        }
    }
}
