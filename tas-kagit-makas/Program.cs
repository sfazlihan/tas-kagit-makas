Random randomSayi = new Random();

int bilgisayarHamlesi = 0;
int kullanıcıHamlesi = 0;

int kullanıcıSkor = 0;
int bilgisayarSkor = 0;

string deger;

Console.WriteLine("          TAŞ - KAĞIT - MAKAS OYUNUNA BAŞLADINIZ          ");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("\nBir Seçim Yapınız\n1-) TAŞ\n2-) KAĞIT\n3-) MAKAS\n\n");
        deger = Console.ReadLine();
        kullanıcıHamlesi = int.Parse(deger);
        bilgisayarHamlesi = randomSayi.Next(1, 4);

        if (kullanıcıHamlesi != 1 && kullanıcıHamlesi != 2 && kullanıcıHamlesi != 3)
        {
            Console.Clear();
            Console.WriteLine("Yanlış Giriş Yaptınız. Lütfen Tekrar Tuşlayınız.\n");
        }

        // 1-) TAŞ
        // 2-) KAĞIT
        // 3-) MAKAS

        //Bilgisayar TAŞ seçti.
        if (bilgisayarHamlesi == 1 && kullanıcıHamlesi == 1)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : TAŞ\nKullanıcı : TAŞ ");
            Console.WriteLine("Berabere");
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);
        }

        else if (bilgisayarHamlesi == 1 && kullanıcıHamlesi == 2)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : TAŞ\nKullanıcı : KAĞIT ");
            Console.WriteLine("Kullanıcı Kazandı.");
            kullanıcıSkor++;
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);
        }

        else if (bilgisayarHamlesi == 1 && kullanıcıHamlesi == 3)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : TAŞ\nKullanıcı : MAKAS ");
            Console.WriteLine("Bilgisayar Kazandı.");
            bilgisayarSkor++;
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);

        }








        //Bilgisayar KAĞIT seçti.
        if (bilgisayarHamlesi == 2 && kullanıcıHamlesi == 1)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : KAĞIT\nKullanıcı : TAŞ ");
            Console.WriteLine("Bilgisayar Kazandı.");
            bilgisayarSkor++;
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);


        }
        else if (bilgisayarHamlesi == 2 && kullanıcıHamlesi == 2)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : KAĞIT\nKullanıcı : KAĞIT ");
            Console.WriteLine("Berabere");
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);


        }
        else if (bilgisayarHamlesi == 2 && kullanıcıHamlesi == 3)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : KAĞIT\nKullanıcı : MAKAS ");
            Console.WriteLine("Kullanıcı Kazandı.");
            kullanıcıSkor++;
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);


        }








        //Bilgisayar MAKAS seçti.
        if (bilgisayarHamlesi == 3 && kullanıcıHamlesi == 1)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : MAKAS\nKullanıcı : TAŞ ");
            Console.WriteLine("Kullanıcı Kazandı.");
            kullanıcıSkor++;
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);


        }
        else if (bilgisayarHamlesi == 3 && kullanıcıHamlesi == 2)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : MAKAS\nKullanıcı : KAĞIT ");
            Console.WriteLine("Bilgisayar Kazandı.");
            bilgisayarSkor++;
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);

        }
        else if (bilgisayarHamlesi == 3 && kullanıcıHamlesi == 3)
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar : MAKAS\nKullanıcı : MAKAS ");
            Console.WriteLine("Berabere");
            Console.WriteLine("\nBilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);

        }


    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Yanlış Giriş Yaptınız. Lütfen Tekrar Tuşlayınız.\n");
    }


}


//10 tur oynadıktan sonra sonucu ekrana yazdırıyoruz ve oyun bitiyor.
if (bilgisayarSkor == kullanıcıSkor)
{
    Console.Clear();
    Console.WriteLine("Bilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);
    Console.WriteLine("Oyun Berabere Bitti.");
    Console.Read();
    Environment.Exit(25);
}
else if (bilgisayarSkor < kullanıcıSkor)
{
    Console.Clear();
    Console.WriteLine("Bilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);
    Console.WriteLine("Oyun Bitmiştir. Kazanan => Kullanıcı!");
    Console.Read();
    Environment.Exit(25);
}
else if (bilgisayarSkor > kullanıcıSkor)
{
    Console.Clear();
    Console.WriteLine("Bilgisayar : " + bilgisayarSkor + "   Kullanıcı : " + kullanıcıSkor);
    Console.WriteLine("Oyun Bitmiştir. Kazanan => Bilgisayar!");
    Console.Read();
    Environment.Exit(25);
}