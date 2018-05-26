using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.Core
{
    public interface IPersonService
    {
        Person GetPerson(int personId);
    }

    public class PersonService : IPersonService
    {
        private readonly IPersonRespository _personRepository;

        public PersonService(IPersonRespository personRespository)
        {
            _personRepository = personRespository;
        }

        public Person GetPerson(int personId)
        {
            return _personRepository.GetPerson(personId);
        }
    }
}
