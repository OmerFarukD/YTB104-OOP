namespace Interface;

// SOLID -> I Interface lerin ayrışması prensibi.
public class ExcelDatabase : IDatabase
{
    public void Add(Patient patient)
    {
        Console.WriteLine($"Hasta Excel Veri tabanına eklendi.");
        Console.WriteLine(patient);
    }

    public void Delete(Patient patient)
    {
        Console.WriteLine($"Hasta Excel Veri tabanından silindi.");
        Console.WriteLine(patient);
    }

    public void GetAll()
    {
        Console.WriteLine("Tüm Hastalar Excel veri tabanından getirildi.");
    }

    public void GetByName(string Name)
    {
        Console.WriteLine("Hasta Excel veri tabanından getirildi."+Name);
    }

    public void Update(Patient patient)
    {
        Console.WriteLine($"Hasta Excel Veri tabanından güncellendi.");
        Console.WriteLine(patient);
    }
}
