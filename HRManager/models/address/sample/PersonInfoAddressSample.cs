
using System;
namespace MasonApps.HRManager.models.address.sample
{
    public class PersonInfoAddressSample : Address
    {
        private static string[] address1s =  {"400 Metlock Dr.",      "90218 Jones Bridge Rd.",      "487 Abbotts Bridge",    "100 Peachtree St.",
                                        "315 MLK St.",     "73 Alabama Rd.",     "934 Loblolly Lane",    "800 Ocean View Drive",
                                        "214 Broad St.",    "1 Park Place",    "1 Board Walk",      "105 Saltcreek Point",
                                        "100 Main St.",    "200 Mansell Rd",     "5678 Level Creek Rd"};

        private static string[] address2s =  {"Box 3",      "Box 75",      "Suite 100",    "Suite 56",
                                        "Room 53",     "Room 921",     "Floor 3b",    "Lot 8382",
                                        "Floor 643",    "Lot 1-c",    "Suite 8-q",      "Block 87-b",
                                        "Lot 83",    "Box 82-g",     "Room 150"};

        private static string[] cities =  {"Atlanta",      "Blackshear",      "Macon",    "Columbus",
                                        "Reno",     "Boulder",     "Culver City",    "Franklin",
                                        "Fargo",    "Helena",    "Billings",      "Rincon",
                                        "Summerville",    "Monterey",     "Souix Falls"};

        private static string[] stateProvinces =  {"Alabama",      "Georgia",      "Florida",    "Nevada",
                                        "California",     "Utah",     "Arkansas",    "Texas",
                                        "Vermont",    "New York",    "Virginia",      "North Carolina",
                                        "Idaho",    "Oregon",     "South Dakota"};

        private static string[] postalCodes =  {"12325",      "30518",      "21894",    "31516",
                                        "30020",     "30240",     "40105",    "68306",
                                        "43303",    "11221",    "23256",      "90871",
                                        "68123",    "90386",     "34976"};

        public PersonInfoAddressSample() : this(1) { }
        public PersonInfoAddressSample(int seed)
        {
            Country = "United States";
            //TODO: Add StringHelper utils
            //Address1 = StringHelper.GetRandomString(address1s, new Random(seed));
            //Address2 = StringHelper.GetRandomString(address2s, new Random(DateTime.Now.Millisecond - seed));
           // City = StringHelper.GetRandomString(cities, new Random(seed));
           // StateProvince = StringHelper.GetRandomString(stateProvinces, new Random(seed));
           // PostalCode = StringHelper.GetRandomString(postalCodes, new Random(seed));

        }
    }
}
