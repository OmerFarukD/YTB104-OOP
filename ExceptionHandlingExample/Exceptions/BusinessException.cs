namespace ExceptionHandlingExample.Exceptions;

public class BusinessException  : Exception
{

    public BusinessException(string mesaj) : base(mesaj)
    {
        
    }
}
