using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurser1
{
    class Laborationer : ILaborationer
    {

     


        public string LaborationNamn { get; set; }
        public string LaborationKurs { get; set; }
        public int LaborationKlass { get; set; }


        public void AddLaborationer(string laborationNamn, string laborationKurs, int laborationKlass)
        {
            this.LaborationNamn = laborationNamn;
            this.LaborationKurs = laborationKurs;
            this.LaborationKlass = laborationKlass;
            


        }

    }
}







