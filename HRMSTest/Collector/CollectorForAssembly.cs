using System.Collections.Generic;

namespace HRMSTest.Collector
{
    public class CollectorForAssembly
    {

        public List<CollectorForClass> ClassCollectors { get; set; }

        public CollectorForAssembly() {
            ClassCollectors = new List<CollectorForClass>();
        } 
    }
}
