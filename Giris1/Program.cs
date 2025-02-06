

Console.WriteLine("Merhaba ben Ömer");
Console.WriteLine("Merhaba ben Ömer");
Console.WriteLine("Merhaba ben Ömer");
Console.WriteLine("Merhaba ben Ömer");
Console.WriteLine(456*225);
Console.WriteLine(456 * 225);
Console.WriteLine(456 * 225);
Console.WriteLine(456 * 225);

// değişken_tipi değişken_ismi = değişken_değeri;


// string veri tipi :  metinsel ifadelere karşılık gelen veri tipidir.
// Üü Ğğ Şş İı Öö Çç 
string name = "Ömer Faruk";
string surname = "Doğan";

Console.WriteLine(name);
Console.WriteLine(surname);


// int (Integer) : tam sayılara karşılık gelen veri tipidir.

// toplama , Çıkarma , çarpma , bölme 
int sayi1 = 150;
int sayi2 = 30;

Console.WriteLine(sayi1 + sayi2);
Console.WriteLine(sayi1 - sayi2);
Console.WriteLine(sayi1 * sayi2);
Console.WriteLine(sayi1 / sayi2);

// double : ondalıklı ve tam sayılara karşılık gelen bir veri tipidir.

double boy = 1.92;


// bool : doğruluk değeri taşır sadece true veya false değerlerini alır.

bool dogru = true;
bool yanlis = false;



// operatörler : 
// Aritmetik operatörler :  + - / * %

// 10/3 =  3.3333333
Console.WriteLine(10 % 3);


string ad = "Mauro Emanuel ";
string soyad = "Icardi";

string tamAd = ad +soyad;
Console.WriteLine(tamAd);

// Karşılaştırma operatörleri:  < , > , <= , >= , ==, != 

Console.WriteLine(3<5); // true
Console.WriteLine(3<=3); // true
Console.WriteLine(35>=46); // false
Console.WriteLine(88!=88); // false
Console.WriteLine(9==9); // true



// Mantıksal operatörler: && -> ve  || -> veya  ! -> değil 

Console.WriteLine("**********************************Mantıksal**********************************");

Console.WriteLine((4==5) || (3>2));
//                   0    veya    1        = 1 

Console.WriteLine((4 == 5) && (3 > 2));
//                    0          1       = 0


Console.WriteLine(!(4 == 5) && (3 > 2));


int age = 19;
bool okuma_yazma = true;


if (age>=18 && okuma_yazma == true)
{
    Console.WriteLine("Ehliyet alabilirsiniz.");
}
else
{
    Console.WriteLine("Ehliyet alamazsın büyü de gel.");
}


int num1 = 20;
int num2 = 25;

string islem = "+";

if (islem == "+")
{
    Console.WriteLine(num1+num2);
}
else if(islem == "-")
{
    Console.WriteLine(num1-num2);
}
else
{
    Console.WriteLine("Lütfen sadece - veya + operatörüyle çalışınız.");
}

// numbers adında bir dizi olsun ve for döngüsüyle teker teker bütün sayıları gezerken 
//   {1,3,4,5,7,8,6,11,44,34}
//  Tek sayı : 3,
//   Çift sayı : 6


int not = 85;

// not değeri 50 - 60 (d) arasında ise  D
// not değeri 60 - 70(d) arasında ise  C
// not değeri 70 - 80(d) arasında ise  B
//not değeri 80 - 90(d) arasında ise  A
// not değeri 90 - 100(d) arasında ise  S
// 50 altı ise F 
// Bunun dışında alınan her değer için 0 - 100 arasında bir puan giriniz


if(not<0 || not > 100)
{
    Console.WriteLine("0 - 100 arasında bir puan giriniz");
}
else if (not < 50)
{
    Console.WriteLine("Kaldınız : F");
}



if(not>50 && not <= 60)
{
    Console.WriteLine("D");
}

else if (not > 60 && not <= 70)
{
    Console.WriteLine("C");
}
else if (not > 70 && not <= 80)
{
    Console.WriteLine("B");
}
else if (not > 80 && not <= 90)
{
    Console.WriteLine("A");
}
else if (not > 90 && not <= 100)
{
    Console.WriteLine("S");
}