using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.Core
{
    public interface IPersonRespository
    {
        Person GetPerson(int personId);
    }

    public class PersonRespository : IPersonRespository
    {
        private readonly IList<Person> _personList;
        public Person GetPerson(int personId)
        {
            return _personList.Where(person => person.Id == personId).FirstOrDefault();
        }

        public PersonRespository()
        {
            _personList = new List<Person>
                                {
                                    new Person{Id = 1, FirstName = "John", LastName = "Doe"},
                                    new Person{Id = 2, FirstName = "Richard", LastName = "Roe"},
                                    new Person{Id = 3, FirstName = "Amy", LastName = "Adams"}
                                };
        }
    }
}
