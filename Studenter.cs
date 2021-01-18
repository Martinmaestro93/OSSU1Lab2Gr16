using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iiiii
{
    public partial class Studenter : Form
    {

        BindingList<Studenter> studentInfo;

        private TextBox studenterstudentID;
        private TextBox studenterstudentNamn;
        private TextBox studenterpersonnummer;

        private TextBox studenteremail;
        private TextBox studentertelefonnummer;
      
        private Button buttonTabortStudenter;
        private Button buttonLäggTillStudenter;
        private ListBox studenterListaStudenter;






        public Studenter()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Font;

            this.studenterstudentID = new TextBox();
            this.studenterstudentNamn = new TextBox();
            this.studenterpersonnummer = new TextBox();

            this.studenteremail = new TextBox();
            this.studentertelefonnummer = new TextBox();


            this.buttonTabortStudenter = new Button();
            this.buttonLäggTillStudenter = new Button();

            this.studenterListaStudenter = new ListBox();




            this.studenterstudentID.Location = new Point(169, 26);
            this.studenterstudentID.Size = new Size(100, 20);
            this.studenterstudentID.Text = "Student ID";

            this.studenterstudentNamn.Location = new Point(169, 57);
            this.studenterstudentNamn.Size = new Size(100, 20);
            this.studenterstudentNamn.Text = "Namn";

            this.studenterpersonnummer.Location = new Point(169, 57);
            this.studenterpersonnummer.Size = new Size(100, 20);
            this.studenterpersonnummer.Text = "Personnummer";



            this.studenteremail.Location = new Point(169, 57);
            this.studenteremail.Size = new Size(100, 20);
            this.studenteremail.Text = "Email";

            this.studentertelefonnummer.Location = new Point(169, 57);
            this.studentertelefonnummer.Size = new Size(100, 20);
            this.studentertelefonnummer.Text = "Telefonnummer";

            this.studenterListaStudenter.FormattingEnabled = true;
            this.studenterListaStudenter.Location = new Point(169, 57);
            this.studenterListaStudenter.Size = new Size(100, 20);


            this.buttonLäggTillStudenter.Location = new Point(180, 70);
            this.buttonLäggTillStudenter.Size = new Size(75, 23);
            this.buttonLäggTillStudenter.Text = "lägg till ny student";
            this.buttonLäggTillStudenter.Click += new System.EventHandler(this.LäggTill_Click);

            this.buttonTabortStudenter.Location = new Point(180, 50);
            this.buttonTabortStudenter.Size = new Size(75, 23);
            this.buttonTabortStudenter.Text = "Raddera studenter";
            this.buttonTabortStudenter.Click += new System.EventHandler(this.Tabort_Click);

            this.ClientSize = new Size(292, 266);
         
            this.Controls.Add(buttonLäggTillStudenter);
            this.Controls.Add(buttonTabortStudenter);
            this.Controls.Add(studenterListaStudenter);
            this.Controls.Add(studenterstudentID);
            this.Controls.Add(studenterstudentNamn);
            this.Controls.Add(studenterpersonnummer);

            this.Controls.Add(studenteremail);
            this.Controls.Add(studentertelefonnummer);
            this.Text = "Studenter";
            this.Load += new EventHandler(Studenter_Load);



        }

        private void Studenter_Load(object sender, EventArgs e)
        {

            InitializeListOfParts();
            studenterListaStudenter.DataSource = studentInfo;
            studenterListaStudenter.DisplayMember = "student";
            studentInfo.AddingNew += new AddingNewEventHandler(studentInfo_AddingNew);
            studentInfo.ListChanged += new ListChangedEventHandler(studentInfo_ListChanged);








        }



        private void InitializeListOfParts()
        {

            studentInfo = new BindingList<Studenter>();

            studentInfo.AllowNew = true;
            studentInfo.AllowRemove = true;


            studentInfo.RaiseListChangedEvents = true;


            studentInfo.AllowEdit = false;







        }


        void studentInfo_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Studenter(int.Parse(studenterstudentID.Text), studenterstudentNamn, long.Parse(studenterpersonnummer.Text),
                studenteremail, int.Parse(studentertelefonnummer.Text));

        }

        // Add the new part unless the part number contains
        // spaces. In that case cancel the add.
        private void LäggTill_Click(object sender, EventArgs e)
        {
            Studenter student = studentInfo.AddNew();

            studenterstudentNamn.Text = studenterstudentNamn.ToString();

            //  personalNamnText.Text = personalNamnText.ToString();

            ///ToString(personalNamnText) = "hej";

            int.Parse(studenterstudentID.Text);

            long.Parse(studenterpersonnummer.Text);
            studenteremail.Text = studenteremail.ToString();
            int.Parse(studentertelefonnummer.Text);


        }

        void studentInfo_ListChanged(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());

        }

        private void Tabort_Click(object sender, EventArgs e)
        {
            studentInfo.Clear();

        }






    }
}
