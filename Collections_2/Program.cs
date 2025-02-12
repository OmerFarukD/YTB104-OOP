

using Collections_2;

List<Product> products = new List<Product>()
{
    new Product{Name = "Dyson Süpürge",Price=25000, Stock=250},
    new Product{Name = "Prada Çanta",Price=50000, Stock=120},
    new Product { Name="Roborock Robot süpürge",Price=35000,Stock=25}
};

products.Add(new Product { Name="Philips Süpürge",Price=14000,Stock=25});
//CokluElemanEkle(products);
ElemanCikar(products,"C");
ListeEkranaYaz(products);

Console.WriteLine("-----------------------------------------------------------------");

ElemanVarMi(products, "XYZ");

GetAllProductsByPriceRange(products,35000,50000);

Console.WriteLine("---------------------------------------------------------");

GetAllProductPricesSum(products);
GetAllProductsAverage(products);



// ekrana yazma işlemi 
void ListeEkranaYaz(List<Product> products)
{
    //foreach (Product product in products)
    //{
    //    Console.WriteLine(product);
    //}

    // lambda expression :  =>

    products.ForEach(p =>Console.WriteLine(p));
}



void CokluElemanEkle(List<Product> products)
{

    List<Product> added = new List<Product>()
    {
        new Product{Price=2500,Name="A",Stock=140},
        new Product{Price=50,Name="B",Stock=36},
        new Product{Price=150,Name="C",Stock=47},
        new Product{Price=1550.25,Name="D",Stock=19},
    };

    products.AddRange(added);
}

void ElemanCikar(List<Product> products, string name)
{ 
    foreach(Product p in products)
    {
        if(p.Name== name)
        {
            products.Remove(p);
            break;
        }
    }


}


void ElemanVarMi(List<Product> urunler, string name)
{
    // Geleneksel Yöntem
    // flag yöntemi;

    bool isPresent = false;

    //1. Yöntem


    //foreach(Product p in urunler)
    //{
    //    if(p.Name == name)
    //    {
    //        isPresent = true;
    //        break;
    //    }
    //}


    // Exists : İLGİLİ elaman varsa true, yoksa false değerini döner : Lambda şeklinde yazılan yapı 
    isPresent = products.Exists(p=>p.Name == name);


    //1. yÖNTEM

    //if(isPresent == false)
    //{
    //    Console.WriteLine("Aradığınız ürün Bulunamadı .");
    //}
    //else
    //{
    //    Console.WriteLine("Aradığınız ürün bulundu.");
    //}

    // 2. Yöntem Ternary Operator

    string metin = isPresent == true ? "Aradığınız ürün bulundu." : "Aradığınız ürün Bulunamadı .";
    Console.WriteLine(metin);
}


void GetAllProductsByPriceRange(List<Product> urunler, double min, double max)
{
    Console.WriteLine($"------------------------Ürün Filteleme : {min}-{max}------------------------");


    // 1. Yöntem
    List<Product> filteredProducts = new List<Product>();

    //foreach (Product product in urunler)
    //{
    //    if(product.Price<=max && product.Price >= min)
    //    {
    //        filteredProducts.Add(product);
    //    }
    //}

    //2. Yöntem

    // FindAll : filtreleme işlemleri için kullanılır. lambda bir doğruluk değeri taşımak zorundadır.
    filteredProducts = urunler.FindAll(product => product.Price<=max && product.Price>=min);

    ListeEkranaYaz(filteredProducts);
}




void GetAllProductPricesSum(List<Product> products)
{
    double total = 0;

    //foreach(Product p in products)
    //{
    //    //total = total + p.Price;

    //    total += p.Price;
    //}
    //Console.WriteLine($"Ürünlerin fiyatları toplamı : {total}");


    // Sum: listedeki tüm elemanların belli alanlarınla göre toplama yapar
    // lambda alanı liste içerisinde ki gezmiş olduğu her elemanın belli 1 alanı için çalışır.

    total = products.Sum(x=>x.Price);
    Console.WriteLine($"Ürünlerin fiyatları toplamı : {total}");
}


void GetAllProductsAverage(List<Product> urunler)
{
    //  1500 , 2500 , 3000 
    // ortalama = (1500+2500+3000) / 3 = 2500 


    // 1. Yöntem
    double average = 0;
    //double total = 0;

    //foreach (Product p in urunler)
    //{
    //    total += p.Price;
    //}

    //average = total / urunler.Count;

    average = urunler.Average(x=>x.Price);

    Console.WriteLine($"Ürünlerin Ortalaması: {average}");

}