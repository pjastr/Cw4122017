using System;
namespace ConsoleApplication71
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new NaszWyjatekException("sdddffdf");
        }
    }

    class NaszWyjatekException:System.Exception
    {
        public NaszWyjatekException() { }

        public NaszWyjatekException(string message) : base(message) { }
        public NaszWyjatekException(String message, Exception innerException)
            : base(message, innerException) { }
    }
}
