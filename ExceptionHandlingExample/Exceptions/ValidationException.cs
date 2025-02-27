namespace ExceptionHandlingExample.Exceptions;

internal class ValidationException : Exception
{

    public ValidationException(string mesaj) : base(mesaj)
    {
        
    }
}
