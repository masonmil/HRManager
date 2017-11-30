using System;
using System.Collections.Generic;

namespace console
{
    partial class T4Runtime
    {
        List<Tuple<string,string,string>> props;
        public T4Runtime(List<Tuple<string, string, string>> p)
        {
            this.props = p;
        }
    }
}
