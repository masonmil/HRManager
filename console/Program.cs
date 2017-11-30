using System;
using System.Collections.Generic;
using System.Reflection;
using MasonApps.HRManager.models.address;

namespace console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var tups =  new List<Tuple<string, string, string>>();

            //TODO: REMOVE ADDRESS CLASS AND MAKE DYNAMIC
            var a = typeof(Address).Assembly;

            var types = a.GetTypes();
            Array.Sort(types,
                delegate (Type type1, Type type2)
                {
                    return string.Compare(type1.FullName, type2.FullName, StringComparison.Ordinal);
                });

            foreach (var type in types)
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
                        tups.Add(Tuple.Create(type.FullName,type.Name,propertyInfo.Name));
                    }
                }
            }




            T4Runtime page = new T4Runtime(tups);
            String pageContent = page.TransformText();

            System.IO.File.WriteAllText("outputPage.txt", pageContent);

            Console.WriteLine(pageContent);
           // Console.ReadLine();
        }
    }
}




       
