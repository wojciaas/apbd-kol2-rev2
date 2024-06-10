namespace apbd_kol2ef_rev2.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException()
        {
        }
    

        public DomainException(string? message) : base(message)
        {
        }

        public DomainException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}