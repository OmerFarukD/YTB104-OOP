namespace Polymorphism_2;


// statik polymorphism : overloading = metodların dönüş tipleri aynı ismi aynı paramtre sayısı farklı olan

public interface IMatematik
{
    void Topla(double sayi1, double sayi2);

    void Topla(double sayi1, double sayi2,double sayi3);


    void Sum(params double[] numbers);

    void Carpma(double sayi1, double sayi2);

    void Carpma(double sayi1, double sayi2, double sayi3);



    void Bolme(double sayi1, double sayi2);

    void Cikarma(double sayi1, double sayi2);


}
