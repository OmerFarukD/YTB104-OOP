namespace OOP_example;

public class ProductManager
{
    ProductData data = new ProductData();


    public void UrunListele()
    {
        Console.WriteLine("Ürünler Listelendi.");
        List<Product> products = data.GetAll();

        products.ForEach(x=>Console.WriteLine(x));

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Ürünler ve Detayları");
        Console.WriteLine($"Ürün Sayısı : {products.Count}");
        Console.WriteLine($"Ürünlerin Fiyat toplamı : {products.Sum(x=>x.Price)}");
        Console.WriteLine($"Ürünlerin Fiyat Ortalaması : {products.Average(x => x.Price)}");

        Console.WriteLine($"En Ucuz Ürün => {products.MinBy(x => x.Price)}");
        Console.WriteLine($"En Pahalı Ürün =>  {products.MaxBy(x => x.Price)}");

    }


    public void KategoriyeGoreUrunListele()
    {
        Console.WriteLine("Lütfen Kategori adını Giriniz: ");
        string category = Console.ReadLine();

        List<Product> filteredProducts = data.GetAllByCategory(category);
        Console.WriteLine($"{category} kategorisine ait ürünler");

        filteredProducts.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Ürünler ve Detayları");
        Console.WriteLine($"Ürün Sayısı : {filteredProducts.Count}");
        Console.WriteLine($"Ürünlerin Fiyat toplamı : {filteredProducts.Sum(x => x.Price)}");
        Console.WriteLine($"Ürünlerin Fiyat Ortalaması : {filteredProducts.Average(x => x.Price)}");

        Console.WriteLine($"En Ucuz Ürün => {filteredProducts.MinBy(x=>x.Price)}");
        Console.WriteLine($"En Pahalı Ürün =>  {filteredProducts.MaxBy(x => x.Price)}");
    }


    public void FiyatAraliginaGoreUrunListele()
    {
        Console.WriteLine("Lütfen ürünün minimum değerini giriniz.");
        double min = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Lütfen ürünün maksimum değerini giriniz.");
        double max = Convert.ToDouble(Console.ReadLine());


        List<Product> filtered = data.GetAllByPriceRange(min,max);
        Console.WriteLine($"{min} TL - {max} TL arasındaki ürünler");

        filtered.ForEach(x=> Console.WriteLine(x));


        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Ürünler ve Detayları");
        Console.WriteLine($"Ürün Sayısı : {filtered.Count}");

        Console.WriteLine($"Ürünlerin Fiyat toplamı : {filtered.Sum(x => x.Price)}");
        Console.WriteLine($"Ürünlerin Fiyat Ortalaması : {filtered.Average(x => x.Price)}");

        Console.WriteLine($"En Ucuz Ürün => {filtered.MinBy(x => x.Price)}");
        Console.WriteLine($"En Pahalı Ürün =>  {filtered.MaxBy(x => x.Price)}");

    }


    public void UrunIsmineGoreListele()
    {
        Console.WriteLine("Lütfen aramak istediğiniz metni giriniz.");

        string text = Console.ReadLine();

        List<Product> filtered = data.GetAllByNameContains(text);

        Console.WriteLine($"İsminde {text} geçen ürünler : ");

        filtered.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Ürünler ve Detayları");
        Console.WriteLine($"Ürün Sayısı : {filtered.Count}");

        Console.WriteLine($"Ürünlerin Fiyat toplamı : {filtered.Sum(x => x.Price)}");
        Console.WriteLine($"Ürünlerin Fiyat Ortalaması : {filtered.Average(x => x.Price)}");

        Console.WriteLine($"En Ucuz Ürün => {filtered.MinBy(x => x.Price)}");
        Console.WriteLine($"En Pahalı Ürün =>  {filtered.MaxBy(x => x.Price)}");
    }


    public void StokLariBitenUrunleriListele()
    {
        Console.WriteLine("Stokları biten ürünlerin Listesi :");
        List<Product> filtered = data.GetAllStockFinished();

        filtered.ForEach(x=>Console.WriteLine(x));

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Ürünler ve Detayları");
        Console.WriteLine($"Ürün Sayısı : {filtered.Count}");

        Console.WriteLine($"Ürünlerin Fiyat toplamı : {filtered.Sum(x => x.Price)}");
        Console.WriteLine($"Ürünlerin Fiyat Ortalaması : {filtered.Average(x => x.Price)}");

        Console.WriteLine($"En Ucuz Ürün => {filtered.MinBy(x => x.Price)}");
        Console.WriteLine($"En Pahalı Ürün =>  {filtered.MaxBy(x => x.Price)}");
    }
}
