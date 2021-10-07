using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise1
{
    //All car will contain (have a) relationship
    //E.g. BMW has a CarIDInfo etc.
    class CarIDInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No owner";
        //This read as if it does not have owner, then set it "No owner";
    }
}
