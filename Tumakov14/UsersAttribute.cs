using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tumakov14
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor)]
    class UsersAttribute : Attribute
    {
        public string Developer;
        public string Organization
        {
            get;
            set;
        }
        public UsersAttribute(string developer)
        {
            Developer = developer;
        }
    }
}
