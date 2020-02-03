using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompareUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kullanıcı adı belirleyiniz");
            string kullanici_adi = Console.ReadLine();
           PAROLAUYUSMADIGINDA:
            Console.WriteLine("parola belirleyiniz");
            string parola1 = Console.ReadLine();
            Console.WriteLine("parolanızı tekrar giriniz");
            string parola2 = Console.ReadLine();
            int kontrol = string.Compare(parola1, parola2); //parola1 ve parola2 yi karsılastırır aynıysa sıfır der ve kontrol degiskenine sıfır tanımlanır.
            if (kontrol==0)
            {
                Console.WriteLine("Kayıt işlemi başarılıdır");
            }
            else
            {
                Console.WriteLine("parolalar uyuşmuyor");
                goto PAROLAUYUSMADIGINDA;
            }
            Console.ReadKey();
        }
    }
}
