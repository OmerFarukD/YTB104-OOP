namespace Linq;

public class Detail
{
    public string StudentName;
    public double Average;

    public override string ToString()
    {
        return $"Öğrenci Adı : {StudentName}, Ortalama : {Average}";
    }
}
