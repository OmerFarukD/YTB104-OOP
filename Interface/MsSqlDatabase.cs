namespace Interface;

public class MsSqlDatabase : IDatabase
{
    public void Add(Patient patient)
    {
        Console.WriteLine($"Hasta MsSql Veri tabanına eklendi.");
        Console.WriteLine(patient);
    }

    public void Delete(Patient patient)
    {
        Console.WriteLine($"Hasta MsSql Veri tabanından silindi.");
        Console.WriteLine(patient);
    }

    public void GetAll()
    {
        Console.WriteLine("Tüm Hastalar MsSql veri tabanından getirildi.");
    }

    public void GetByName(string Name)
    {
        Console.WriteLine("Hasta MsSql veri tabanından getirildi." + Name);
    }

    public void Update(Patient patient)
    {
        Console.WriteLine($"Hasta MsSql Veri tabanından güncellendi.");
        Console.WriteLine(patient);
    }
}
