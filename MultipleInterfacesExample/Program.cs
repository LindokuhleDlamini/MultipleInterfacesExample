using System;

namespace MultipleInterfacesExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomLogger customLogger = new CustomLogger();
            IFileLogger fileLogger = new CustomLogger();
            IDatabaseLogger databaseLogger = new CustomLogger();

            customLogger.LogError("Failed to compute");
            fileLogger.LogError("Failed to compute");
            databaseLogger.LogError("Failed to compute");

            Console.ReadLine();
        }
    }
}
