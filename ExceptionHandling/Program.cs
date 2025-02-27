
try
{
    Console.WriteLine("1. Sayıyı girinizz.");
    double sayi1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("2. Sayıyı girinizz.");
    double sayi2 = Convert.ToDouble(Console.ReadLine());

    if (sayi2 == 0)
    {
        throw new Exception("Bölen Kısım 0 olamaz.");
    }

    double sonuc = sayi1 / sayi2;
    Console.WriteLine(sonuc);
}
catch (FormatException)
{
    Console.WriteLine("Girmiş olduğunuz sayı düzgün formatta değil");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}





