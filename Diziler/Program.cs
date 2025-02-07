// dizinin_tipi[] dizi_adı = {degerler};
// sehirler dizisi 
string[] sehirler = {"Tunceli","Malatya","İstanbul","Elazığ","Ankara","İzmir","Çanakkale","Çankırı"};
//                       0         1          2         3        4       5        6            7
//Console.WriteLine(sehirler[0]);
//Console.WriteLine(sehirler[1]);
//Console.WriteLine(sehirler[2]);
//Console.WriteLine(sehirler[3]);
//Console.WriteLine(sehirler[4]);
//Console.WriteLine(sehirler[5]);
//Console.WriteLine(sehirler[6]);


// for döngüsü : Bazı kodların tekrarlanarak çalışmasını sağlayan döngülerdir.

// for (baslangıc_degeri ; koşul; artış_miktarı )

// 1-10 a kadar bütün sayıları ekran çıktısı olarak veren kodu yazınız.


//Console.WriteLine("1-10 a kadar bütün sayıları ekran çıktısı olarak veren kodu yazınız.");
//for (int i=1; i<=10;i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("1 den 10 a kadar tek sayıların ekran çıktısı.");
//// 1 3 5 7 9

//for (int i = 1; i<=10;i+=2)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("birden den 10 a kadar çift sayıların ekran çıktısı.");
//// 2 4 6 8 10

//for (int i = 2; i <= 10; i += 2)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i<=6; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}

// foreach 

//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}


Console.WriteLine($"Dizinin boyutu : {sehirler.Length}");

for (int i = 0; i < sehirler.Length; i++)
{
    Console.WriteLine(sehirler[i]);
}