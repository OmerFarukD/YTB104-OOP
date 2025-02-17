namespace Inheritance
{
    internal class Manager : Employee
    {
        public int TeamCount;

        public override string ToString()
        {
              return $"Adı : {Name}, Surname : {Surname}, Maaş : {Salary}, Takım Sayısı: {TeamCount}, Email:{Email}";

        }
    }
}
