namespace Encapsulation_2;
// Kullanıcıdan Yazar adı ve soyadı alındıktan sonra Fullname diye bir alan oluşturup ekrana çıktıyı ver.
// Yazarın adı ve soyadı kısmı sadece yazılabilir olsun okunabilir olmasın 

// Kullanıcı fiyatı bilgisini girdikten sonra %20 KDV uygulasın.



// private 
// public
public class Book
{

    private double _price;

    public string Title { get; set; }
    public string ISBN { get; set; }


    // 1. Yöntem

    //public double Price {
    //    get
    //    {
    //        return _price;
    //    }

    //    set
    //    {
    //        _price = value * 1.20;
    //    }


    //}

    //2. Yöntem
    public double Price {
        get => _price;
        set => _price = value*1.20;
    
    }

    public string AuthorFirstName { private get; set; }

    public string AuthorSurname { private get; set; }

    //public string AuthorFullName {
    //    //get {

    //    //    return $"{AuthorFirstName} {AuthorSurname}";
    //    //} 

    //    get=> $"{AuthorFirstName} {AuthorSurname}";

    //}

    public string AuthorFullName => $"{AuthorFirstName} {AuthorSurname}";


    public override string ToString()
    {
        return $"Başlık : {Title}, Isbn : {ISBN}, Fiyatı : {Price}, Yazarı :{AuthorFullName} ";
    }
}
