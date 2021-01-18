using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogskolan_Sarob
{
    class Lararlag2 : ILarare
    {
        private int lararlagID;
        private int personalID;

        public Lararlag2() { }
        public Lararlag2(int IDofLärarlag, int IDofPersonal)
        {
            this.lararlagID = IDofLärarlag;
            this.personalID = IDofPersonal;
        }

        public int LararLagID
        {
            get { return lararlagID; }
            set { lararlagID = value; }
        }


        public int PersonalID
        {
            get { return personalID; }
            set { personalID = value; }

        }

        public void laddaLarareFranFil()
        {
            throw new NotImplementedException();
        }

        public void sparaLarareTillFil()
        {
            throw new NotImplementedException();
        }
    }
}
