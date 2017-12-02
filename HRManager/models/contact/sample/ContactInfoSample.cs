using System;
using MasonApps.HRManager.helper;
using MasonApps.HRManager.models.company.sample;
using MasonApps.HRManager.models.person.sample;

namespace MasonApps.HRManager.models.contact.sample
{
    public class ContactInfoSample: Contact
    {
        private static string[] emaildomains = { "gmail.com", "yahoo.com", "bellsouth.net", "me.com", "msn.com", "charter.net", "comcast.net" };

        public ContactInfoSample() : this(1) { }
        public ContactInfoSample(int seed)
        {
            HydrateSampleContact(this, seed);
        }

        public static void HydrateSampleContact(Contact contact, int seed)
        {
            PersonInfoSample.HydratePersonInfoSample(contact, seed);

            contact.Company = new CompanyInfoSample(seed);
            contact.EmailAddress = string.Format("{0}.{1}@{2}", contact.FirstName, contact.LastName, StringHelper.GetRandomString(emaildomains, new Random(seed)));
        }
    }
}
