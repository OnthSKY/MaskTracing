using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        IPersonService _personService;

        public PttManager(IPersonService personService)
        {
            _personService = personService;
        }

        public void GiveMask(Person person)
        {
            if(_personService.CheckPerson(person))
                Console.WriteLine("Maskelendi");
            else
                Console.WriteLine("Maskelenemedi !");
        }
    }
}
