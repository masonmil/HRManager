using System.Collections.Generic;

namespace HRMSTest.Collector
{
    public class CollectorForClass
    {
        public string FullyQualifiedName { get; set; }
        public string Name { get; set; }
        public List<CollectorForAttribute> AttributeCollectors { get; set; }
        public CollectorForEnum AttributeEnumCollector { get; set; }

        public CollectorForClass(string fqName, string name){

            FullyQualifiedName = fqName;
            Name = name;
            AttributeCollectors = new List<CollectorForAttribute>();
        }

        public override string ToString() => Name;
    }

}
