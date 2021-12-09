using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new FileHandler("File.txt"));
            Console.WriteLine(manager.Manage());
            Manager manager2 = new Manager(new MyWebRequest("https://docs.microsoft.com"));
            Console.WriteLine(manager2.Manage());
            Console.ReadKey();
        }
    }
}
