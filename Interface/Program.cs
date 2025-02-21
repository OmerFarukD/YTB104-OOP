
// interface : C# da sözleşme gibi davranan yapılara interface denir.
using Interface;

Console.WriteLine("Hello, World!");

// Şirkette 2 tane veri tabanı olduğunu düşünelim ve bu veri tabanları hepsinde
// CRUD(Create - Read- Update- Delete) operasyonları mevcuttur.
// Sistem şuan MsSql de çalışırken ilerleyen zamanlarda MongoDb alternatifi de eklenmesi isteniyor
// Sistemi kurgulayınız.

// Hastane Bilişim Yönetim Sistemi üzerinde çalışan bir program.
// Ve Bu sistemde Hasta Ekleme Silme Güncelleme ve Listeleme operasyonlarının olduğunu düşünelim


// Sonrasından şirket Excel e de CRUD operasyonlarını istedi 

// Bütün veri tabanlarına isme göre arama özelliği getiriniz.

Patient patient = new Patient("Semih Tarhan","Dudak",19);

MsSqlDatabase msSqlDatabase = new MsSqlDatabase();
MongoDbDatabase mongoDbDatabase = new MongoDbDatabase();
ExcelDatabase excelDatabase = new ExcelDatabase();


Console.WriteLine("Hastayı Hangi Veri tabanına eklemek istersiniz");
Console.WriteLine("1 -> MsSql");
Console.WriteLine("2 -> MongoDb");
Console.WriteLine("3 -> Excel");

int db = Convert.ToInt32(Console.ReadLine());

if(db == 1)
{
    msSqlDatabase.Add(patient);
    msSqlDatabase.GetByName("Semih Tarhan");
}
else if (db == 2)
{
    mongoDbDatabase.Add(patient);
    mongoDbDatabase.GetByName("Semih Tarhan");
}
else if(db == 3)
{
    excelDatabase.Add(patient);
    excelDatabase.GetByName("Semih Tarhan");
}