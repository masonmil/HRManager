using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HRMSTest.Collector;
using HRMSTest.Collector.Helpers;

namespace console
{
    partial class T4Runtime
    {
        const string DLL_NAME = "MasonApps.HRManager.dll";

        CollectorForAssembly _collector;

        public T4Runtime()
        {
            _collector = new CollectorForAssembly();

            var a = Assembly.LoadFile(ResolveDLLPath(DLL_NAME));

            CollectorHelper.AppendTypes(_collector, a);


        }

        static string ResolveDLLPath(string p) => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), p);

    }



}
