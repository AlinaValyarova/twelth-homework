using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov14
{

    class DeveloperInfoAttribute
    {  
        public string Developer;
        public string Date
        {
            get;
            set;
        }
        public DeveloperInfoAttribute(string developer)
        {
            Developer = developer;
        }
    }
}
