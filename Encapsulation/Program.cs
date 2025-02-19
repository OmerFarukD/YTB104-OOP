// kullanıcıdan ilgili alanları alarak ekran çıktısını veriniz.

using Encapsulation;

User user = new User();

user.SetFirstname("Buse");
user.SetLastname("Doğan");
user.SetPassword("Parola123.");

Console.WriteLine($"Kullanıcı tam adı :  {user.GetFullName()}");