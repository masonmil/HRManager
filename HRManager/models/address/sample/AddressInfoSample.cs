using System;
namespace MasonApps.HRManager.models.address.sample
{
    public class AddressInfoSample : Address
    {

        public AddressInfoSample()
        {
            Address1 = "100 Any Street";
            Address2 = "Suite 100";
            City = "Atlanta";
            StateProvince = "Georgia";
            Country = "United States";
            PostalCode = "30020";
        }
    }
}
