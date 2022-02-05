using Kraken.Interfaces.Dynamic.Library.Interfaces;
using Kraken.Interfaces.Dynamic.Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace People.DataStore.SQL
{
    public class SQLRepository : IPersonRepository
    {
        public IEnumerable<PersonModel> GetPeople()
        {
            using (var ctx = new PeopleModelContainer())
            {
                var people = ctx.People.Select(
                    p =>
                    new PersonModel
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        StartDate = p.StartDate,
                        Rating = p.Rating
                    });

                return people.ToList();
            }
        }
    }
}
