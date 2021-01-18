using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace iiiii
{


    interface IStudenter
    {


        public int studentID { get; set; }

        public string studentNamn { get; set; }

        public long personnummer { get; set; }



        public string email { get; set; }

        public int telefonnummer { get; set; }



        public bool läggTillStudentButton { get; set; }

       public bool tabortStudentButton { get; set; }



    }



    public partial class Studenter : IStudenter
    {


        private int studentID { get; set; }

        private string studentNamn { get; set; }

        private long personnummer { get; set; }



        private string email { get; set; }

        private int telefonnummer { get; set; }



        private bool läggTillStudentButton { get; set; }

        private bool tabortStudentButton { get; set; }

        private int v1studentID;

        private long v2personnummer;

        private int v3telefonnummer;


        private TextBox studentNamntextbox;



        private TextBox emailtextbox;

        public Studenter(int studentID, string studentNamn, long personnummer, string email, int telefonnummer, bool läggTillStudentButton, bool tabortStudentButton)
        {

            this.studentID = studentID;
            this.studentNamn = studentNamn;
            this.personnummer = personnummer;

            this.email = email;
            this.telefonnummer = telefonnummer;

            this.läggTillStudentButton = läggTillStudentButton;
            this.tabortStudentButton = tabortStudentButton;

        }

        public Studenter(int v1studentID, TextBox studentNamntextbox, long v2personnummer, TextBox emailtextbox, int v3telefonnummer)
        {

            this.v1studentID = v1studentID;
            this.studentNamntextbox = studentNamntextbox;
            this.v2personnummer = v2personnummer;

            this.emailtextbox = emailtextbox;
            this.v3telefonnummer = v3telefonnummer;




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
