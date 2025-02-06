SayHello();
//DaireIslemleri();

//Console.WriteLine(BurcSonucu(15,1));

BurcHesapla();

// Değer döndürmeyen fonksiyonlar : işlem yapılması gereken ve herhangi bir değer döndürmeyen fonskiyonlardır.
// void fonsyion_ismi(parametre){}


void SayHello()
{
    Console.WriteLine("Hello, World!");
}

void SayHello1(string name)
{
    Console.WriteLine($"Hello {name}");
}



double Pi()
{
    return 3.14159265358979;
}

double DaireAlan(double yariCap)
{
    double alan = Pi() * yariCap * yariCap;
    return alan;
}

double DaireCevre(double yariCap)
{
    double cevre = 2 * Pi() * yariCap;
    return cevre;
}

void DaireIslemleri()
{
    Console.WriteLine("Lütfen dairenin yarı çapını giriniz : ");
    double r =Convert.ToDouble(Console.ReadLine());
    double cevre = DaireCevre(r);
    double alan = DaireAlan(r);


    Console.WriteLine($"Girmiş olduğunuz yarıçap : {r} cm");
    Console.WriteLine($"Dairenin alanı : {alan} santimetre kare (cm2)");
    Console.WriteLine($"Dairenin Çevresi : {cevre} santimetre kare (cm2)");
}

// Kullanıcıdan Gün ay bilgilerini alarak bir burç hesaplama fonksiyonunu yazınız.

// 1 -> Ocak
// 2 -> Şubat
// 3 -> Mart
// 4 -> Nisan
// 5 -> Mayıs
// 6 -> Haziran
// 7 -> Temmuz
// 8 -> Ağustos
// 9 -> Eylül
// 10 -> Ekim
// 11-> Kasım 
// 12 -> Aralık


string BurcSonucu(int gun, int ay)
{
    // Mart 21 < x <Mart 31 
    // Nisan 
    if(((gun >=21 && ay==3) && (gun<=31 && ay==3)) || ((gun >= 1 && ay == 4) && (gun <= 19 && ay == 4)))
    {
        return "KOÇ";
    }



    // 20 Nisan
    else if (((gun >= 20 && ay == 4) && (gun <= 31 && ay == 4)) || ((gun >= 1 && ay == 5) && (gun <= 20 && ay == 5)))
    {
        return "Boğa";
    }

    // 21 Mayıs
    else if (((gun >= 21 && ay == 5) && (gun <= 31 && ay == 5)) || ((gun >= 1 && ay == 6) && (gun <= 21 && ay == 6)))
    {
        return "İkizler";
    }

    // 22 Haziran
    else if (((gun >= 22 && ay == 6) && (gun <= 31 && ay == 6)) || ((gun >= 1 && ay == 7) && (gun <= 22 && ay == 7)))
    {
        return "Yengeç";
    }

    // 23 Temmuz
    else if (((gun >= 23 && ay == 7) && (gun <= 31 && ay == 7)) || ((gun >= 1 && ay == 8) && (gun <= 22 && ay == 8)))
    {
        return "Aslan";
    }

    // 23 Ağustos
    else if (((gun >= 23 && ay == 8) && (gun <= 31 && ay == 8)) || ((gun >= 1 && ay == 9) && (gun <= 22 && ay == 9)))
    {
        return "Başak";
    }

    // 23 Eylül
    else if (((gun >= 23 && ay == 9) && (gun <= 31 && ay == 9)) || ((gun >= 1 && ay == 10) && (gun <= 22 && ay == 10)))
    {
        return "Terazi";
    }

    else if (((gun >= 23 && ay == 10) && (gun <= 31 && ay == 10)) || ((gun >= 1 && ay == 10) && (gun <= 22 && ay == 10)))
    {
        return "Akrep";
    }
    else if (((gun >= 22 && ay == 11) && (gun <= 31 && ay == 11)) || ((gun >= 1 && ay == 12) && (gun <= 21 && ay == 12)))
    {
        return "Yay";
    }
    else if (((gun >= 22 && ay == 12) && (gun <= 31 && ay == 12)) || ((gun >= 1 && ay == 1) && (gun <= 19 && ay == 1)))
    {
        return "Oğlak";
    }

    else if (((gun >= 20 && ay == 1) && (gun <= 31 && ay == 1)) || ((gun >= 1 && ay == 2) && (gun <= 18 && ay == 2)))
    {
        return "Kova";
    }


    else if (((gun >= 19 && ay == 2) && (gun <= 31 && ay == 2)) || ((gun >= 1 && ay == 3) && (gun <= 20 && ay == 3)))
    {
        return "Balık";
    }
    else
    {
        return "Yanlış tarih girdiniz.";
    }
}


int AyRakamHesapla(string ay)
{
    if (ay.ToLower() == "ocak")
    {
        return 1;
    }

    else if (ay.ToLower() == "şubat")
    {
        return 2;
    }

    else if (ay.ToLower() == "mart")
    {
        return 3;
    }
    else if (ay.ToLower() == "nisan")
    {
        return 4;
    }
    else if (ay.ToLower() == "mayıs")
    {
        return 5;
    }

    else if (ay.ToLower() == "haziran")
    {
        return 6;
    }

    else if (ay.ToLower() == "temmuz")
    {
        return 7;
    }

    else if (ay.ToLower() == "ağustos")
    {
        return 8;
    }
    else if (ay.ToLower() == "eylül")
    {
        return 9;
    }

    else if (ay.ToLower() == "ekim")
    {
        return 10;
    }

    else if (ay.ToLower() == "kasım")
    {
        return 11;
    }

    else if (ay.ToLower() == "aralık")
    {
        return 12;
    }
    else
    {
        return 0;
    }
}

void BurcHesapla()
{
    // kullanıcıdan verileri al  1 Ocak 
    Console.WriteLine("Lütfen Doğum gününüzü giriniz: ");
    int gun =Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen Doğum ayınızı yazınız : (Ocak, Subat vs)");
    string ay = Console.ReadLine();

    // girilen ay değerinin Rakamsal değerini al : Ocak =1
    int ayDegeri = AyRakamHesapla(ay);
    // mAyıs, MAYIS, mayıs, Mayıs, MayıS
   

    // Burcunu hesaplasın

    string burc = BurcSonucu(gun,ayDegeri);
    // Ekran Çıktısı -> Burcunuz : Oğlak

    Console.WriteLine($"Burcunuz : {burc}");
}