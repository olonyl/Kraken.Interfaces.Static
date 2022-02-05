using System;
using System.Runtime.Serialization;

namespace Kraken.Interfaces.Dynamic.Library.Models
{
    [DataContract]
    public class PersonModel
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public int Rating { get; set; }
    }
}
