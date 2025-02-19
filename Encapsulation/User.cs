using System.Runtime.ExceptionServices;

namespace Encapsulation;
// Erişim bildirgeçleri 
// public -> Her yerden erişilebilir 
//private -> Sadece kullanıldığı class içinden erişimi olan yapılardır.
public class User
{
    private string Firstname;
    private string Lastname;
    private string FullName;
    private string Password;


    public void SetFirstname(string text)
    {
        Firstname = text;
    }

    public void SetLastname(string text)
    {
        Lastname = text;
    }

    //public void SetFullName(string text)
    //{
    //    FullName = text;
    //}

    public void SetPassword(string text)
    {
        Password = text;
    }


    public string GetFirstname()
    {
        return Firstname;
    }

    public string GetLastname()
    {
        return Lastname;
    }


    public string GetFullName()
    {
        return $"{Firstname} {Lastname}";
    }

    public string GetPassword()
    {
        return Password;
    }



    public override string ToString()
    {
        return $"Kullanıcı Tam Adı : {FullName}, Parola: {Password}";
    }

}
