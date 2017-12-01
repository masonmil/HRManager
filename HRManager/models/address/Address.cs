namespace MasonApps.HRManager.models.address
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public Address() { }

        public Address(Address address)
        {
            Address1 = address.Address1;
            Address2 = address.Address2;
            City = address.City;
            StateProvince = address.StateProvince;
            Country = address.Country;
            PostalCode = address.PostalCode;
        }

    }
}
