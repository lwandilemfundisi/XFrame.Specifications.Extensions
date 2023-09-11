using JetBrains.Annotations;

namespace XFrame.Specifications.Extensions.Exceptions
{
    public class DomainError : Exception
    {
        protected DomainError(string message)
            : base(message)
        {
        }

        protected DomainError(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        [StringFormatMethod("format")]
        public static DomainError With(string format, params object[] args)
        {
            var message = args.Length <= 0
                ? format
                : string.Format(format, args);
            return new DomainError(message);
        }

        [StringFormatMethod("format")]
        public static DomainError With(Exception innerException, string format, params object[] args)
        {
            var message = args.Length <= 0
                ? format
                : string.Format(format, args);
            return new DomainError(message, innerException);
        }
    }
}
