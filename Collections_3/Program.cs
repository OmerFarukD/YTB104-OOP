Console.WriteLine("Hello, World!");

// HashSet bir listede tekrarlayan eleman varsa o tekrarlayan elemanı tekrar edilmemiş hali ile ekler.
HashSet<int> sayilar = new HashSet<int> { 1,1,2,2,3,3,4,4,5,5,678,987};

//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}

// anahtar değer şeklinde tutulan çoklu veri öbeklerine Dictionary denilebilir.


// Karga - Crow
// Türkçe - İngilizce sözlüğü oluşturunuz.

Dictionary<string,string> myDictionary = new Dictionary<string,string>();

myDictionary.Add("Crow","Karga");
myDictionary.Add("Lion","Aslan");
myDictionary.Add("Tiger","Kaplan");
myDictionary.Add("Crow1", "Karga");


Console.WriteLine(myDictionary["Crow"]);


foreach (KeyValuePair<string,string> sozluk in myDictionary)
{
    Console.WriteLine($"ingilizce : {sozluk.Key} -> Türkçe : {sozluk.Value}");
}


Dictionary<string, double> manav = new Dictionary<string, double>();

manav.Add("Elma",25.5);

manav.Add("Armut", 25.5);

manav.Add("Karpuz", 25.5);

manav.Add("Kiraz", 25.5);

manav.Add("Kayısı", 25);

foreach (KeyValuePair<string, double> sozluk in manav)
{
    Console.WriteLine($"Meyve Adı : {sozluk.Key} -> Değeri : {sozluk.Value}");
}
