using System;
namespace MasonApps.HRManager.models.company.sample
{
    public class CompanyInfoSample : Company
    {
        private static string[] names =  {
                            "Sears",
                            "Walmart",
                            "JCPenny",
                            "Nordstrom",
                            "Target",
                            "Kohls",
                            "Macy's",
                            "Amazon",
                            "KMart",
                            "Bloomingdales",
                            "Barnes & Noble"};

        public CompanyInfoSample() : this(1) { }
        public CompanyInfoSample(int seed)
        {
            //Name = StringHelper.GetRandomString(names, new Random(seed));
            FullName = Name + " Inc.";
            //Address = new CompanyAddressSample(seed);

        }
    }
}
