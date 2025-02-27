using ExceptionHandlingExample.Exceptions;

namespace ExceptionHandlingExample;

public class UserController
{
    private UserManager userManager = new UserManager();

    public void Run()
    {
        Console.WriteLine("Lütfen Email giriniz : ");
        string email = Console.ReadLine();

        Console.WriteLine("Lütfen Parola giriniz : ");
        string password = Console.ReadLine();


        User user = new User()
        {
            Email = email,
            Password = password
        };


        try
        {
            string message = userManager.Login(user);
            Console.WriteLine(message);
        }catch(Exception ex)
        {
            if(ex is BusinessException)
            {
                Console.WriteLine("İş Kuralından geçmedi.");
                Console.WriteLine(ex.Message);
                return;
            }

            if(ex is ValidationException)
            {
                Console.WriteLine("Validasyon kuralından geçmedi.");
                Console.WriteLine(ex.Message);
                return;
            }


        }

      

    }
}


//catch(BusinessException ex)
//        {
//            Console.WriteLine("İş Kuralından geçmedi.");
//            Console.WriteLine(ex.Message);
//        }catch(ValidationException ex)
//        {
//            Console.WriteLine("Validasyon kuralından geçmedi.");
//Console.WriteLine(ex.Message);
//        }