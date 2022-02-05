using Kraken.Interfaces.Dynamic.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<PersonModel> GetPeople()
    {
        var people = new List<PersonModel>
            {
               new PersonModel {FirstName="Olonyl",LastName="Landeros",StartDate = DateTime.Parse("06/11/1987"),Rating=28},
               new PersonModel {FirstName="Jose",LastName="Horacio",StartDate = DateTime.Parse("06/05/1967"),Rating=28},
               new PersonModel {FirstName="Dante",LastName="Jordan",StartDate = DateTime.Parse("12/12/1960"),Rating=28}
            };
        return people;
    }
}
