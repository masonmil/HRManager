using MasonApps.HRManager.models.contact;

namespace MasonApps.HRManager.models.businessCard
{
    public class BusinessCard
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public Contact Contact { get; set; }

        public BusinessCard()
        {
        }
    }
}
