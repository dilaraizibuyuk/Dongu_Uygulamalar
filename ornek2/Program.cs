using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {     //while ile, kullanıcı adını şifreyi doğru girerse mesaj vericez yanlış girerse de hata vericez 3 kere yanlış girma hakkı var
            int islem_sayisi = 3;
            while (true)
            {
                Console.WriteLine("Kullanıcı adını giriniz:");
                string user_name = Console.ReadLine();
                Console.WriteLine("Şifrenizi adını giriniz:");
                string password = Console.ReadLine();
                if (user_name=="admin"&&password=="12345")
                {
                    Console.WriteLine("Tebrikler başarılı giriş yaptınız.");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
                    if (islem_sayisi>0)
                    {
                        islem_sayisi -= 1;
                    }
                    if (islem_sayisi==0)
                    {
                        Console.WriteLine("İşlem hakkınız bitmiştir.");
                        break;//break koymazsak tekrar kullanıcı adı ve şifre sorar
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
