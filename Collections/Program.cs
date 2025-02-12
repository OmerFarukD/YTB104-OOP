using System.Collections;

Console.WriteLine("Hello, World!");
// Listeler tip güvenli listeler oluşturmak için kullanılır.
// <> Jenerik argüman 

string[] sehirler = { "Malatya", "Tunceli", "Sivas", "Erzurum", "Kars", "Bingöl" };

List<string> cities = new List<string>() { "Malatya", "Tunceli", "Sivas", "Erzurum", "Kars", "Bingöl" };


// ArrayList : Tip güvenli olmayan liste

ArrayList arraylist = new ArrayList() { 1, 1, 3, 4, 5, "Selamlar", "456", true, false };

foreach (object deneme in arraylist)
{
    Console.WriteLine(deneme);
}



List<User> users = new List<User>()
{
    new User{Name="Buse",Surname="Doğan"},
    new User{Name ="Uzay",Surname="Doğan"},
    new User{Name = "Sanal", Surname="Doğan"},
    new User{Name="Evren",Surname="Doğan"},
};


foreach (User user in users)
{
    Console.WriteLine(user);
}

//Console.WriteLine("Dizi işlemleri");
//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

cities.Add("İstanbul");

cities.Remove("Kars");

//Console.WriteLine("Listeler işlemleri");
//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}


class User
{
    public string Name;
    public string Surname;



    public override string ToString()
    {
        return $"Kullanıcı Adı : {Name}, Kullanıcı Soyadı : {Surname}";
    }

}
// Product : Name, Stock, Price 
// Ürünler listesi oluşturup ekran çıktısı veriniz.

