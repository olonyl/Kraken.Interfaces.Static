using Kraken.Interfaces.Dynamic.Library.Models;
using System.Collections.Generic;

namespace Kraken.Interfaces.Dynamic.Library.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<PersonModel> GetPeople();
        //Person GetPerson(string lastName);
        //void AddPerson(Person newPerson);
        //void UpdatePerson(string lastName, Person updatedPerson);
        //void DeletePerson(string lastName);
        //void UpdatePeople(IEnumerable<Person> updatePeople);
    }
}
