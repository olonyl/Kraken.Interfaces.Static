using Kraken.Interfaces.Dynamic.Library.Interfaces;
using Kraken.Interfaces.Dynamic.Library.Models;
using People.DataStore.Service.Library.PeopleWCFService;
using System.Collections.Generic;

namespace People.DataStore.Service.Library
{
    public class ServiceRepository : IPersonRepository
    {
        private ServiceClient _service;
        public ServiceRepository()
        {
            _service = new ServiceClient();
        }
        public IEnumerable<PersonModel> GetPeople()
        {
            return _service.GetPeople();
        }
    }
}
