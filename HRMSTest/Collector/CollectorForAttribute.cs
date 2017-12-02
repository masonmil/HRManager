namespace HRMSTest.Collector
{
    public class CollectorForAttribute
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public CollectorForAttribute(string n, string dt)
        {
            Name = n;
            DataType = dt;
        }

        public override string ToString() => Name;
    }
}
