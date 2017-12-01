using System;
using System.Collections.Generic;
using System.Reflection;

namespace console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var tups = new List<Tuple<string, string, string>>();
            var a = Assembly.LoadFile(@"/Users/mason/Projects/masonmil/HRManagerSln/HRManager/bin/Debug/netstandard2.0/MasonApps.HRManager.dll");

            AppendTypes(tups, a);

            T4Runtime page = new T4Runtime(tups);
            String pageContent = page.TransformText();

            Console.WriteLine(pageContent);
            // System.IO.File.WriteAllText("outputPage.txt", pageContent);
            // Console.ReadLine();
        }

        private static void AppendTypes(List<Tuple<string, string, string>> list, Assembly a)
        {
            var types = a.GetTypes();
            Array.Sort(types,
                delegate (Type type1, Type type2)
                {
                    return string.Compare(type1.FullName, type2.FullName, StringComparison.Ordinal);
                });

            foreach (Type type in types)
            {
                if (type.IsClass)
                {
                    AppendProperties(list, type);                    
                }
                else if (type.IsEnum)
                {
                    AppendEnum(type);
                }

            }
        }

        private static void AppendEnum(Type e)
        {
            var enumNames = Enum.GetNames(e);
            var enumValues = Enum.GetValues(e);
        }

        private static void AppendProperties(List<Tuple<string, string, string>> list, Type type)
        {
            // get all public static properties of MyClass type
            var propertyInfos = type.GetProperties();

            // sort properties by name
            Array.Sort(propertyInfos,
                        delegate (PropertyInfo propertyInfo1, PropertyInfo propertyInfo2)
                        {
                            return string.Compare(propertyInfo1.Name, propertyInfo2.Name, StringComparison.Ordinal);
                        });

            // write property names
            foreach (var propertyInfo in propertyInfos)
            {
                if (propertyInfo.PropertyType == typeof(string))
                {
                    list.Add(Tuple.Create(type.FullName, type.Name, propertyInfo.Name));
                }
            }
        }
    }
}




       
