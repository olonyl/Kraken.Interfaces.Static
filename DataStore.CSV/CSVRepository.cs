using Kraken.Interfaces.Dynamic.Library.Interfaces;
using Kraken.Interfaces.Dynamic.Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace DataStore.CSV
{
    public class CSVRepository : IPersonRepository
    {
        private string _path;
        public CSVRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            _path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }
        public IEnumerable<PersonModel> GetPeople()
        {
            var people = new List<PersonModel>();
            if (File.Exists(_path))
            {
                var sr = new StreamReader(_path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    var per = new PersonModel()
                    {
                        FirstName = elems[0],
                        LastName = elems[1],
                        StartDate = DateTime.Parse(elems[2]),
                        Rating = Int32.Parse(elems[3]),
                    };
                    people.Add(per);
                }
            }
            return people;
        }
    }
}
