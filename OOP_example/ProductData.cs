
namespace OOP_example;

// Single Responsibility 

// Filtreleme ve listeleme operasyonlarını yapıyor
public class ProductData
{
    List<Product> products = new List<Product>()
    {
        new Product{Name = "Dyson Süpürge",Price=25000, Stock=250, CategoryName="Ev Aletleri"},
        new Product{Name = "Prada Çanta",Price=50000, Stock=120,CategoryName="Aksesuar"},
        new Product{Name="Roborock Robot süpürge",Price=35000,Stock=25,CategoryName="Ev Aletleri"},
        new Product{Name="Rayban Gözlük",Price=15000,Stock = 2, CategoryName="Aksesuar"},
        new Product{Name="Dior Sauvage", Price=7000,CategoryName="Kozmetik",Stock=25},
        new Product{Name="Bez Dolap",CategoryName="Ev Aletleri",Price=350,Stock=21},
        new Product{Name="Samsung m51",CategoryName="Teknoloji",Price=15000,Stock=34},
        new Product{Name="Samsung S22 Ultra",CategoryName="Teknoloji",Price=35000,Stock=4},
        new Product{Name="Msi Bravo 15",CategoryName="Teknoloji",Price=35000,Stock=14},
        new Product{Name="Volume Maskara",CategoryName="Kozmetik",Price=224.5, Stock=0},
        new Product{Name="Paradoxe Virtual Flower Parfüm",CategoryName="Kozmetik",Price=3800, Stock=10},
        new Product{Name="Onvo televizyon",CategoryName="Teknoloji",Price=7263,Stock=0},
        new Product{Name="Apple iPad 10. Nesil",CategoryName="Teknoloji",Price=14699,Stock=20},
        new Product{Name="Dekor Luna Avize",CategoryName="Ev Aletleri",Price=379.9,Stock=25},
        new Product{Name="Iphone 13 Kılıf",CategoryName="Aksesuar",Price=140.99,Stock=74}
    };



    public List<Product> GetAll()
    {
        return products;
    }


    public List<Product> GetAllByNameContains(string text)
    {
        return products.FindAll(p=> p.Name.ToLower().Contains(text.ToLower()));
    }

    public List<Product> GetAllByPriceRange(double min, double max)
    {
        return products.Where(x => x.Price >= min && x.Price <= max).ToList();
    }

    public List<Product> GetAllByCategory(string categoryName)
    {
        return products.FindAll(x=>x.CategoryName == categoryName);
    }

    public List<Product> GetAllStockFinished()
    {
        return products.Where(x=>x.Stock==0).ToList();
    }

}
