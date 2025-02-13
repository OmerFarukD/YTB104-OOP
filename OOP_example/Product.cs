namespace OOP_example;

public class Product
{
    public string Name;
    public double Price;
    public int Stock;
    public string CategoryName;


    public override string ToString()
    {
        return $"Adı : {Name}, Ürün Fiyatı : {Price}, Stok : {Stock}, Kategorisi : {CategoryName}";
    }

}
