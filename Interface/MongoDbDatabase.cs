namespace Interface;

public class MongoDbDatabase : IDatabase
{
    public void Add(Patient patient)
    {
        Console.WriteLine($"Hasta MongoDb Veri tabanına eklendi.");
        Console.WriteLine(patient);
    }

    public void Delete(Patient patient)
    {
        Console.WriteLine($"Hasta MongoDb Veri tabanından silindi.");
        Console.WriteLine(patient);
    }

    public void GetAll()
    {
        Console.WriteLine("Tüm Hastalar MongoDb veri tabanından getirildi.");
    }

    public void GetByName(string Name)
    {
        Console.WriteLine("Hasta MongoDb veri tabanından getirildi." + Name);
    }

    public void Update(Patient patient)
    {
        Console.WriteLine($"Hasta MongoDb Veri tabanından güncellendi.");
        Console.WriteLine(patient);
    }
}
