using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MasonApps.HRManager.models.key
{
    public class Key : BaseKey<long>
    {
        private long id;
        private bool unset = true;
        public Key()
        {
        }

        public Key(long id) : base(id)
        {
            unset = false;
        }

        public override long GetKey()
        {
            return id;
        }
        public bool isEmpty
        {
            get
            {
                return unset || (id == 0);
            }
        }

        public bool IsValidKey(long id)
        {

            return id > 0;
        }

        public override void SetKey(long key)
        {
            id = key;
            unset = false;
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
