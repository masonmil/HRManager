using System;
using System.Collections.Generic;
using System.Reflection;

namespace HRMSTest.Collector.Helpers
{
    public static class CollectorHelper
    {

        public static void AppendTypes(CollectorForAssembly collector, Assembly a)
        {
            var types = a.GetTypes();
            var enumCollectors = new List<CollectorForEnum>();
            Array.Sort(types,
                delegate (Type type1, Type type2)
                {
                    return string.Compare(type1.FullName, type2.FullName, StringComparison.Ordinal);
                });

            foreach (Type type in types)
            {
                if (type.IsClass)
                {
                    CollectorForClass classCollector = new CollectorForClass(type.FullName, type.Name);
                    AppendProperties(classCollector, type);
                    collector.ClassCollectors.Add(classCollector);
                }
                else if (type.IsEnum && type.Name.EndsWith("Attributes", StringComparison.Ordinal))
                {
                    enumCollectors.Add(AppendEnum(type));
                }

            }

            //Assign enums to respective classes
            foreach (var collectedEnum in enumCollectors)
            {
                var className = collectedEnum.EnumName.Replace("Attributes", "");
                foreach (var classs in collector.ClassCollectors)
                {
                    if (className.Equals(classs.Name))
                    {
                        classs.AttributeEnumCollector = new CollectorForEnum(
                            collectedEnum.EnumName, collectedEnum.Names, collectedEnum.Values);
                        break;
                    }
                }
            }

        }

        public static CollectorForEnum AppendEnum(Type e) => new CollectorForEnum(e.Name, Enum.GetNames(e), Enum.GetValues(e));

        public static void AppendProperties(CollectorForClass c, Type type)
        {
            var propertyInfos = type.GetProperties();

            // sort properties by name
            Array.Sort(propertyInfos,
                        delegate (PropertyInfo propertyInfo1, PropertyInfo propertyInfo2)
                        {
                            return string.Compare(propertyInfo1.Name, propertyInfo2.Name, StringComparison.Ordinal);
                        });

            foreach (var propertyInfo in propertyInfos)
            {
                c.AttributeCollectors.Add(new CollectorForAttribute(propertyInfo.Name, propertyInfo.PropertyType.FullName));
            }
        }
    }
}
