// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//1. Yöntem
Araba araba = new Araba()
{
    Marka = "Toyota",
    Model = "Corolla",
    Fiyat= 1250000
};


Araba araba3 = new Araba()
{
    Marka = "Toyota",
    Model = "Corolla",
    Fiyat = 1250000
};

Araba araba1 = new Araba();
araba1.Model = "M5";
araba1.Marka = "BMW";
araba1.Fiyat = 3000000;


int a = 25;
int b = 25;

//Console.WriteLine(a==b);
//Console.WriteLine(araba==araba3);


//Console.WriteLine(araba);

ArabaManager manager = new ArabaManager();
Araba alinanAraba = manager.GetAraba();
manager.Ekle(alinanAraba);













class Araba
{
    public string Model;
    public string Marka;
    public double Fiyat;
    public override string ToString()
    {
        return $"Arabanın markası : {Marka}, Model: {Model}, Fiyat : {Fiyat}";
    }
}

class ArabaManager
{

    // Araba Modeli boş olamaz.
    // Araba markası boş olamaz
    // Araba fiyatı negatif değer alamaz.
    public void Ekle(Araba araba)
    {
        if (string.IsNullOrWhiteSpace(araba.Marka))
        {
            Console.WriteLine("Araba markası boş olamaz");
            return;
        }

        if (string.IsNullOrWhiteSpace(araba.Model))
        {
            Console.WriteLine("Araba modeli boş olamaz");
            return;
        }

        if (araba.Fiyat < 0)
        {
            Console.WriteLine("Araba fiyatı negatif değer olamaz.");
            return;
        }

        Console.WriteLine($"Araba eklendi {araba}");


    }


    public Araba GetAraba()
    {
        Console.WriteLine("Lütfen araba markası giriniz :");
        string marka = Console.ReadLine();


        Console.WriteLine("Lütfen araba modeli giriniz :");
        string model = Console.ReadLine();


        Console.WriteLine("Lütfen araba fiyatı giriniz :");
        double fiyat =Convert.ToDouble(Console.ReadLine());


        Araba araba = new Araba()
        {
            Marka = marka,
            Fiyat = fiyat,
            Model = model
        };
        return araba;
    }
}