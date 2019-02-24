using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2002
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
           if(x.Name[0] > y.Name[0])
           {
               return 1;
           }

           if (x.Name[0] == y.Name[0])
           {
               return 0;
           }

            return -1;
        }
    }
}
