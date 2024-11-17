namespace VerifySiretNumber.Exceptions;

public class InvalidSiretException : Exception
{
   public InvalidSiretException() : base() { }
    
   public InvalidSiretException(string message) : base(message) { }
}
