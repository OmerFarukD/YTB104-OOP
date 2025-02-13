using Linq;

Console.WriteLine("Hello, World!");

List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,-1,-2,-3,-4,-5,-8};

List<Student> students = new List<Student>()
{
    new Student{Name = "Buse Doğan", Notes = new List<long>{100,95,90}},
    new Student{Name = "Uzay Doğan", Notes = new List<long>{85,50,45}},
    new Student{Name = "Sanal Doğan",Notes = new List<long>{75,85,82}},
    new Student{Name = "Evren Doğan",Notes = new List<long>{60,85,95}},

};
//CiftSayilar(sayilar);
IlkEleman(sayilar);
SonEleman(sayilar);
//ListeyiKucuktenBuyugeSirala(sayilar);
//ListeyiBuyuktenKucugeSirala(sayilar);

ListedekiSayilarinIkiKati(sayilar);

NotOrtalamaListesi(students);
void EkranaYaz(List<int> numbers)
{
    numbers.ForEach(x => Console.WriteLine(x));
}


void CiftSayilar(List<int> numbers)
{

    //1. Yöntem
   //numbers.FindAll(x => x % 2 == 0).ForEach(x=> Console.WriteLine(x));

    //2. Yöntem 
    numbers.Where(x=>x %2==0).ToList().ForEach(x => Console.WriteLine(x));
}

void IlkEleman(List<int> numbers)
{
    Console.WriteLine($"Listenin ilk elemanı : {numbers.First()} ");
}

void SonEleman(List<int> numbers)
{
    Console.WriteLine($"Listenin son elemanı : {numbers.Last()} ");
}


void ListeyiKucuktenBuyugeSirala(List<int> numbers)
{
    numbers.OrderBy(x => x).ToList().ForEach(c=>Console.WriteLine(c));
}

void ListeyiBuyuktenKucugeSirala(List<int> numbers)
{
    numbers.OrderByDescending(x => x).ToList().ForEach(c => Console.WriteLine(c));
}

void ListedekiSayilarinIkiKati(List<int> numbers)
{
    numbers.Select(x => x * 2).ToList().ForEach(c=> Console.WriteLine(c));
}



// öğrencinin adını ve ALmış olduğu notların ortalamasını liste halinde ekran çıktısı olarak veren fonksiyonu yazınız.

void NotOrtalamaListesi(List<Student> students)
{
    List<Detail> details = students.Select(s => new Detail
    {
        StudentName = s.Name,
        Average = s.Notes.Average()
    }).ToList();


    details.ForEach(d=> Console.WriteLine(d));
}

void NotOrtalamaListesi1(List<Student> students)
{
    //foreach ile yapınız

}


void NotOrtalamaListesi2(List<Student> students)
{
    List<Detail> details = new List<Detail>();

    foreach (var student in students)
    {
        Detail detail = new Detail
        {
            StudentName = student.Name,
            Average = student.Notes.Average()
        };
        details.Add(detail);
    }

    foreach (var detail in details)
    {
        Console.WriteLine(detail);
    }
}
