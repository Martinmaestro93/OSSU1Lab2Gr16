using System;
using System.Collections.Generic;
using System.Text;

namespace Hogskolan_Sarob
{
    class Lararlag : ILararlag
    {

        private int lararlagID;
        private int personalID;

        public Lararlag() { }
        public Lararlag(int IDofLärarlag, int IDofPersonal)
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

    }
}
