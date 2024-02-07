using Business.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PttManager manager = new(new PersonManager());
            manager.GiveMask(new Person { FirstName="Kemal", LastName="Yoğurt", NationalIdentity=12, DateOfBirthYear=001});
            Console.ReadLine();
        }
    }
}
