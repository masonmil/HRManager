using System;

namespace console
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //TEMPLATE FOR CREATING UNIT TEST ON PROPERTIES
            T4Runtime page = new T4Runtime();
            String pageContent = page.TransformText();
            Console.WriteLine(pageContent);
            // System.IO.File.WriteAllText("outputPage.txt", pageContent);


        }

    }
}





