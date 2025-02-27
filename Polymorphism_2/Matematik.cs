namespace Polymorphism_2;

public class Matematik : IMatematik
{
    public void Bolme(double sayi1, double sayi2)
    {
        if(sayi2 == 0)
        {
            Console.WriteLine("Bölen kısım 0 olamaz.");
            return;
        }


        double sonuc = sayi1 / sayi2;
        Console.WriteLine($"{sayi1} / {sayi2} = {sonuc}");
    }

    public void Carpma(double sayi1, double sayi2)
    {
        double sonuc = sayi1 * sayi2;
        Console.WriteLine($"{sayi1} * {sayi2} = {sonuc}");
    }

    public void Carpma(double sayi1, double sayi2, double sayi3)
    {
        double sonuc = sayi1 * sayi2 * sayi3;
        Console.WriteLine($"{sayi1} * {sayi2} * {sayi3} = {sonuc}");
    }

    public void Carpma(params double[] sayilar)
    {
        double total = 1;

        foreach(double sayi in sayilar)
        {
            total *= sayi;
        }

        Console.WriteLine($"Çarpım Sonucu  : {total}");
    }

    public void Cikarma(double sayi1, double sayi2)
    {
        double sonuc = sayi1 - sayi2;
        Console.WriteLine($"{sayi1} - {sayi2} = {sonuc}");
    }

    public void Topla(params double[] numbers)
    {
        double total = 0;

        foreach(double number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"Toplam : {total}");
    }

    public void Topla(double sayi1, double sayi2)
    {
        double sonuc = sayi1 + sayi2;
        Console.WriteLine($"{sayi1} + {sayi2} = {sonuc}");
    }

    public void Topla(double sayi1, double sayi2, double sayi3)
    {
        double sonuc = sayi1 + sayi2 + sayi3;
        Console.WriteLine($"{sayi1} + {sayi2} + {sayi3} = {sonuc}");
    }
}
