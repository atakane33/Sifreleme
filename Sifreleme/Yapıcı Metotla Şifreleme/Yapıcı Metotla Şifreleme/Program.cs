using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapıcı_Metotla_Şifreleme
{
    class Şifre
    {
        Random rastgele;
        public Şifre()
        {
            rastgele = new Random();
        }

        public int RastgeleSayı(int min, int max)
        {
            return rastgele.Next(min, max);
        }

        public string RastgeleHarf(int sınır, bool küçükHarf)
        {
            string harfler = "";

            int rastgeleharf;

            char harf;

            int büyükmin;

            büyükmin = 65;

            if (küçükHarf)
            {
                büyükmin = 97;
            }

            for (int i = 0; i < sınır; i++)
            {
                rastgeleharf = rastgele.Next(büyükmin, büyükmin + 25);

                harf = Convert.ToChar(rastgeleharf);

                harfler = harfler + harf;


            }

            return harfler;

        }

        public string ŞifreÜret()
        {
            StringBuilder yapıcı = new StringBuilder();

            Random rnd = new Random();

            int boyut = rnd.Next(0, 8);

            if (boyut == 0)
            {
                int boyutiç = rnd.Next(0);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(0 - boyutiç, false));

                yapıcı.Append(rnd.Next(10000000, 99999999));

            }

            if (boyut == 1)
            {
                int boyutiç = rnd.Next(0, 1);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(1 - boyutiç, false));

                yapıcı.Append(rnd.Next(1000000, 9999999));

            }

            if (boyut == 2)
            {
                int boyutiç = rnd.Next(0, 2);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(2 - boyutiç, false));

                yapıcı.Append(rnd.Next(100000, 999999));

            }

            if (boyut == 3)
            {
                int boyutiç = rnd.Next(0, 3);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(3 - boyutiç, false));

                yapıcı.Append(rnd.Next(10000, 99999));

            }

            if (boyut == 4)
            {
                int boyutiç = rnd.Next(0, 4);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(4 - boyutiç, false));

                yapıcı.Append(rnd.Next(1000, 9999));
            }

            if (boyut == 5)
            {
                int boyutiç = rnd.Next(0, 5);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(5 - boyutiç, false));

                yapıcı.Append(rnd.Next(100, 999));
            }

            if (boyut == 6)
            {
                int boyutiç = rnd.Next(0, 6);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(6 - boyutiç, false));

                yapıcı.Append(rnd.Next(10, 99));
            }

            if (boyut == 7)
            {
                int boyutiç = rnd.Next(0, 7);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(7 - boyutiç, false));

                yapıcı.Append(rnd.Next(1, 9));
            }

            if (boyut == 8)
            {
                int boyutiç = rnd.Next(0, 8);

                yapıcı.Append(RastgeleHarf(boyutiç, true));

                yapıcı.Append(RastgeleHarf(8 - boyutiç, false));

            }

            return yapıcı.ToString();

        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[5];

            Şifre program = new Şifre();

            int sayı = program.RastgeleSayı(1, 100);

            string harf = program.RastgeleHarf(8, true);

            string şifre1 = program.ŞifreÜret();

            string şifre2 = program.ŞifreÜret();

            string şifre3 = program.ŞifreÜret();

            string şifre4 = program.ŞifreÜret();

            string şifre5 = program.ŞifreÜret();

            for (int i = 0; i < isimler.Length; i++)
            {

                Console.Write("İsim Gir : ");

                string isimgir = Console.ReadLine();

                isimler[i] += isimgir;


            }

            Console.WriteLine("İsmi {0} olan kişinin şifresi : {1} ", isimler[0], şifre1);

            Console.WriteLine("İsmi {0} olan kişinin şifresi : {1} ", isimler[1], şifre2);

            Console.WriteLine("İsmi {0} olan kişinin şifresi : {1} ", isimler[2], şifre3);

            Console.WriteLine("İsmi {0} olan kişinin şifresi : {1} ", isimler[3], şifre4);

            Console.WriteLine("İsmi {0} olan kişinin şifresi : {1} ", isimler[4], şifre5);


        }
    }
}
