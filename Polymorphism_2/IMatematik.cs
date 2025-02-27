namespace Polymorphism_2;


// statik polymorphism : overloading = metodların dönüş tipleri aynı ismi aynı paramtre sayısı farklı olan

public interface IMatematik
{
    void Topla(double sayi1, double sayi2);

    void Topla(double sayi1, double sayi2,double sayi3);


    void Topla(params double[] numbers);

    void Carpma(double sayi1, double sayi2);

    void Carpma(double sayi1, double sayi2, double sayi3);

    void Carpma(params double[] sayilar);

    void Bolme(double sayi1, double sayi2);

    void Cikarma(double sayi1, double sayi2);


}
