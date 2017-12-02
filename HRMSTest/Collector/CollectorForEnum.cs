using System;

namespace HRMSTest.Collector
{
    public class CollectorForEnum
    {
        public string EnumName { get; set; }
        public string[] Names { get; set; }
        public Array Values { get; set; }

        public CollectorForEnum(string eName, string[] names, Array vals)
        {
            EnumName = eName;
            Names = names;
            Values = vals;
        }

       
    }

}
