using ExceptionHandlingExample.Exceptions;

namespace ExceptionHandlingExample;

public class UserManager
{
    private UserData userData = new UserData();
    public string Login(User user)
    {
        // ilk başta email validasyon kontrolünü yap
        if (!user.Email.EndsWith("@gmail.com"))
        {
            throw new ValidationException("Kullanıcı Email alanı düzgün formatta değil.");
        }

        if(user.Password.Length < 6)
        {
            throw new ValidationException("Parola alanı minimum 6 haneli olmalıdır.");
        }

        User? getUser = userData.GetByEmail(user.Email);

        if(getUser == null)
        {
            throw new BusinessException("Kullanıcı bulunamadı.");
        }

        if(getUser.Password != user.Password)
        {
            throw new BusinessException("Parola yanlıştır.");
        }


        return "Giriş Başarılıdır.";


    }


}
