// Exceptions/NotFoundException.cs
namespace ProcessTracker.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
}