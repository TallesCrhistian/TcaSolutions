namespace TcaSolutions.Shared.Exceptions
{
    public class CustomException : Exception
    {     
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
          
        }
    }
}
