namespace Collections_2;

public class Product
{
    public string Name;
    public double Price;
    public int Stock;

    public override string ToString()
    {
        return $"Ürün Adı : {Name}, Ürün Adedi : {Stock}, Ürünün Fiyatı : {Price}";
    }
}
