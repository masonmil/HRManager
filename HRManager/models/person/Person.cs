using System.Collections.Generic;
using MasonApps.HRManager.models.address;
using MasonApps.HRManager.models.businessCard;

namespace MasonApps.HRManager.models.person
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<BusinessCard> BusinessCards { get; set; }
        public Address Address { get; set; }

        public Person()
        {
            BusinessCards = new List<BusinessCard>();  
        }
    }
}
