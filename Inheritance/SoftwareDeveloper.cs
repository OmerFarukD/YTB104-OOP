namespace Inheritance;


internal class SoftwareDeveloper : Employee
{
    public string ProgrammingLanguage;

    public override string ToString()
    {
        return $"Adı : {Name}, Surname : {Surname}, Maaş : {Salary}, Dil: {ProgrammingLanguage}, Email:{Email}";
    }
}