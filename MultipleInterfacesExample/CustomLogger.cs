using System;

namespace MultipleInterfacesExample
{
    public class CustomLogger : IFileLogger, IDatabaseLogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"CustomLogger logged error: {error}");
        }

        void IFileLogger.LogError(string error)
        {
            Console.WriteLine($"FileLogger logged error: {error}");
        }

        void IDatabaseLogger.LogError(string error)
        {
            Console.WriteLine($"DatabaseLogger logged error: {error}");
        }
    }
}
