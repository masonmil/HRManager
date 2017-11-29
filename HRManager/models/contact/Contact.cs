using System;
using MasonApps.HRManager.models.company;
using MasonApps.HRManager.models.person;

namespace MasonApps.HRManager.models.contact
{
    public class Contact : Person
    {
        public Company Company { get; set; }

        public string EmailAddress { get; set; }
        public string Phone { get; set; }
               
    }
}
