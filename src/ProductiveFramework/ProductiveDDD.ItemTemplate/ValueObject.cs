using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductiveDDD;

namespace $rootnamespace$
{

    class $safeitemrootname$ : ValueObject
    {
        //ADD A NO EMPTY CONTRUCTOR. 
        //Value objects must be immutable, properties must be read only

        protected override IEnumerable<object> GetEqualityComponents()
        {
            //Add yield return statements for the different properties that matters for equality comparison
            throw new System.NotImplementedException();
        }
    }
}
