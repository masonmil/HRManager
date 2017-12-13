using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasonApps.HRManager.models.key
{
    public abstract class BaseKey<T>
    {
        public abstract T GetKey();
        public abstract void SetKey(T key);

        public BaseKey(T key) => SetKey(key);

        public BaseKey() { }
    }

}
