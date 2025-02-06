// f(x) = x+5
// f(1) = 1 + 5 = 6
// f(20) = 20 + 5 = 25

//g(x, y) = x / y

// g(20,10) = 20 /10 = 2
// g(10,20) =  10 / 20 = 0.5


// fonksiyon oluşturma :
// dönüş_tipi fonksiyon_adı(parametre_tipi değişkeni,parametre_tipi değişkeni){}

// değer döndüren 
// değer döndürmeyen

// parametreli 
// parametresiz
// DRY - Don t Repeat Yourself 


double sonuc = Carpma(40,5);
Console.WriteLine(sonuc);

Console.WriteLine(Bolme(25, 60));

string metin1 = Info("Buse","Doğan","Fizik",100);
string metin2 = Info("Uzay","Doğan","Kimya",85);
string metin3 = Info("Sanal","Doğan","Biyoloji",95);
string metin4 = Info("Evren","Doğan","Matematik",85);



string metin5 = InfoAndAverage("Buse", "Doğan", "Fizik",85,65,100);
string metin6 = InfoAndAverage("Uzay", "Doğan", "Kimya", 25,35,50);
string metin7 = InfoAndAverage("Sanal", "Doğan", "Biyoloji", 75,45,45);
string metin8 = InfoAndAverage("Evren", "Doğan", "Matematik", 110,220,350);

Console.WriteLine("+++++++++++++++++++++++Bilgiler+++++++++++++++++++++++");
Console.WriteLine(metin1);
Console.WriteLine(metin2);
Console.WriteLine(metin3);
Console.WriteLine(metin4);
Console.WriteLine("+++++++++++++++++++++++Bilgiler Ve Ortalamalar+++++++++++++++++++++++");

Console.WriteLine(metin5);
Console.WriteLine(metin6);
Console.WriteLine(metin7);
Console.WriteLine(metin8);

// değer döndüren parametreli fonksiyon : 
double Toplama(double sayi1, double sayi2)
{
    return sayi1 + sayi2;
}

double Cikarma(double sayi1, double sayi2)
{
    return sayi1 - sayi2;
}

double Carpma(double sayi1 , double sayi2)
{
    return sayi1 * sayi2;
}

double Bolme(double sayi1, double sayi2)
{
    return sayi1 / sayi2;
}


// öğrencinin adı , soyadı, dersi , notu bir metin olarak veren bir fonksiyon
string Info(string name, string surname, string lesson, double note)
{
    string metin = $"Öğrenci adı : {name}, Öğrenci Soyadı : {surname}, Dersi:{lesson}, Puan:{note}";
    return metin;
}


// Ortalama Hesabı ve Bilgileri yazan parça fonksiyonlar.
double Average(double s1, double s2, double s3)
{
    return (s1 + s2 + s3) / 3;
}


string InfoMessage(string name,string surname,string lesson,double average,string letterPoint)
{
    return $"Öğrencinin adı : {name}, Soyadı:{surname}, Dersi: {lesson}, Ortalama:{average}, {letterPoint}";
}

// not ortalamasını alsın sonrasında öğrenci bilgileriyle beraber Harf notunu da bir metinsel ifade olarak dönsün.
string InfoAndAverage(string name, string surname, string lesson, double not1, double not2, double not3)
{
    double average = Average(not1,not2,not3);
    string mesaj = "";
    if (average < 50)
    {

        mesaj = InfoMessage(name, surname, lesson, average, "Kaldınız(F).");
    }
    else if (average >= 50 && average < 65)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz(D).");
    }

    else if (average >= 65 && average < 75)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz(C).");
    }

    else if (average >= 75 && average < 85)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz(B).");
    }
    else if (average >= 85 && average <= 100)
    {
        mesaj = InfoMessage(name, surname, lesson, average, "Geçtiniz(A).");
    }
    else
    {
        mesaj = "Girmiş olduğunuz notlar 0 ile 100 arasında olmalıdır.";
    }
    return mesaj;
}

