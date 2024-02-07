using Business.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PttManager manager = new(new PersonManager());
            manager.GiveMask(new Person { FirstName="Sıttık Kemal2", LastName="Yoğurt", NationalIdentity=38620461864, DateOfBirthYear=2000});
            Console.ReadLine();
        }
    }
}
