using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new FileHandler("File.txt"));
            Console.WriteLine(manager.Manage());
            Console.ReadKey();
        }
    }
}
