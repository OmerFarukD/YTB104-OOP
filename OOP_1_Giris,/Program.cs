
//// class tanımladıktan sonra, kullanım aşamasında Class_adı değişken_adı = new Class_Adı();

//Product product = new Product()
//{
//    Name = "TBRUSH Beyazlatıcı ve Diş Silgisi",
//    CategoryName = "Kozmetik",
//    Description = "Açıklama metni",
//    Price = 150.09
//};


//Category category = new Category()
//{
//    Name = "Kozmetik",
//    Description = "Kozmetik açıklama"
//};

//Console.WriteLine("-----------------------------------------------");

//category.EkranaYaz();

//Console.WriteLine("-----------------------------------------------");

//product.EkranaYaz();
//Console.WriteLine("-----------------------------------------------");

//Product product1 = new Product()
//{
//    Name = "Vorch Unisex Siyah Baskılı Oversize Sweatshirt",
//    CategoryName = "Giyim",
//    Description = "Açıklama metni",
//    Price = 539.10
//};

//product1.EkranaYaz();


//int[] sayilar = { 1, 2, 3, 4, 5 };
//foreach(int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}



// oluşturduğumuz classlar referans tiplidir. Referans tipli veriler new anahtar sözcüğü ile oluşturulut.

class Product
{

    // Özellikler 
    public string Name;
    public string Description;
    public string CategoryName;
    public double Price;




    // fonksiyonlar :
    public void EkranaYaz()
    {
        Console.WriteLine($"Ürünün adı : {Name}");
        Console.WriteLine($"Ürünün Kategori adı : {CategoryName}");
        Console.WriteLine($"Ürünün Açıklaması : {Description}");
        Console.WriteLine($"Ürünün Değeri : {Price}");
    }
}


// Category adında bir class oluşturun string Name , string Description alanları olsun
// EkranaYaz fonksiyonunu oluşturunuz.


public class Category
{
    public string Name;
    public string Description;


    public void EkranaYaz()
    {
        Console.WriteLine($"Kategorinin adı : {Name}");
        Console.WriteLine($"Kategorinin açıklaması : {Description}");
    }
}