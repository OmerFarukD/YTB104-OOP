namespace Interface;

public interface IDatabase
{
    void Add(Patient patient);
    void Delete(Patient patient);

    void GetAll();

    void Update(Patient patient);

    void GetByName(string Name);
}
