// Exceptions/ValidationException.cs
namespace ProcessTracker.Exceptions
{
    public class ValidationException : Exception
    {
        public Dictionary<string, string> Errors { get; set; }

        public ValidationException(Dictionary<string, string> errors)
        {
            Errors = errors;
        }

        public ValidationException(string message) : base(message)
        {
            Errors = new Dictionary<string, string>();
        }
    }
}