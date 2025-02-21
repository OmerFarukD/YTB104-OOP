
using Encapsulation_2;
using System.Runtime.InteropServices;

Book book = new Book
{
    AuthorFirstName = "Sait",
    AuthorSurname = "Faik",
    Title = "Abasıyanık",
    Price = 350,
    ISBN = "9783127323207",
};

Book book1 = new Book
{
    AuthorFirstName = "Sait",
    AuthorSurname = "Faik",
    Title = "Abasıyanık",
    Price = 350,
    ISBN = "9783127323207",
};

Category category = new Category("Polisiye", "Polisiye Açıklaması");

Category category1 = new Category("Polisiye", "Polisiye Açıklaması");


Category category2 = category1 with { Name = "Dram"};

Console.WriteLine(category2);

bool esitMi = category == category1;

Console.WriteLine(category);
Console.WriteLine(book);
Console.WriteLine(esitMi);
Console.WriteLine(book==book1);


//category.Name = "Dram";
//category.Description = "Deneme";

