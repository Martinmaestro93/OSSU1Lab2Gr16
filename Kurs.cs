using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogskolan_Sarob
{
    public partial class Kurs : Form
    {
        #region variabler och ctor

        private TextBox lararNamnText;
        private TextBox lararPersonalIDText;
        private TextBox lararPersonnummerText;
        private TextBox lararEmailText;
        private TextBox lararTelNrText;
        private ListBox listBox1;
        private Button button1;
        private TextBox lararLararIDText;
        private Button button2;
        //
        private TextBox studentNamnText;
        private TextBox studentPersonalIDText;
        private TextBox studentPersonnummerText;
        private TextBox studentEmailText;
        private TextBox studentTelNrText;
        private TextBox studentStudentIDText;
        private TextBox studentKlassIDText;
        private ListBox listBox2;
        private Button button3;
        private TextBox personalLararLagsIDText;
        private Button button4;
        //
        private TextBox LaborationNamnText;
        private TextBox LaborationKursText;
        private TextBox LaborationKlassText;
        private ListBox listBox7;
        private Button button5;
        private Button button6;

        public Kurs()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.lararNamnText = new System.Windows.Forms.TextBox();
            this.lararLararIDText = new System.Windows.Forms.TextBox();
            this.lararPersonnummerText = new System.Windows.Forms.TextBox();
            this.lararEmailText = new System.Windows.Forms.TextBox();
            this.lararTelNrText = new System.Windows.Forms.TextBox();
            this.lararLararIDText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lararNamnText.Location = new System.Drawing.Point(169, 26);
            this.lararNamnText.Size = new System.Drawing.Size(500, 20);
            this.lararNamnText.Text = "Lärarnamn";
            ///
            this.lararLararIDText.Location = new System.Drawing.Point(169, 57);
            this.lararLararIDText.Size = new System.Drawing.Size(200, 20);
            this.lararLararIDText.Text = "PersonalID";
            ///
            this.lararPersonnummerText.Location = new System.Drawing.Point(169, 80);
            this.lararPersonnummerText.Size = new System.Drawing.Size(100, 20);
            this.lararPersonnummerText.Text = "Personnummer";
            ///
            this.lararEmailText.Location = new System.Drawing.Point(169, 120);
            this.lararEmailText.Size = new System.Drawing.Size(100, 20);
            this.lararEmailText.Text = "Email";
            ///
            this.lararTelNrText.Location = new System.Drawing.Point(169, 150);
            this.lararTelNrText.Size = new System.Drawing.Size(100, 20);
            this.lararTelNrText.Text = "Telefonnummer";
            ///
         /*   this.personalLararLagsIDText.Location = new System.Drawing.Point(169, 170);
            this.personalLararLagsIDText.Size = new System.Drawing.Size(100, 20);
            this.personalLararLagsIDText.Text = "LärarlagsID"; */
            ///
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Size = new System.Drawing.Size(120, 300);
            this.button1.Location = new System.Drawing.Point(180, 210);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Text = "Lägg till";
            this.button2.Text = "Ta bort";
            this.button2.Location = new System.Drawing.Point(180, 250);
            this.button2.Size = new System.Drawing.Size(75, 23);
            ///this.button1.Location = new System.Drawing.Point(180, 250);
            ///this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.button2.Click += new System.EventHandler(Delete_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lararNamnText);
            this.Controls.Add(this.lararPersonalIDText);
            this.Controls.Add(this.lararPersonnummerText);
            this.Controls.Add(this.lararEmailText);
            this.Controls.Add(this.lararTelNrText);
            this.Controls.Add(this.lararLararIDText);
            this.Text = "Lägg till lärare";
            this.Load += new EventHandler(Form1_Load);

            //


            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.studentNamnText = new System.Windows.Forms.TextBox();
            this.studentStudentIDText = new System.Windows.Forms.TextBox();
            this.studentPersonnummerText = new System.Windows.Forms.TextBox();
            this.studentEmailText = new System.Windows.Forms.TextBox();
            this.studentTelNrText = new System.Windows.Forms.TextBox();
            this.studentKlassIDText = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.studentNamnText.Location = new System.Drawing.Point(269, 26);
            this.studentNamnText.Size = new System.Drawing.Size(500, 20);
            this.studentNamnText.Text = "Lärarnamn";
            ///
            this.studentStudentIDText.Location = new System.Drawing.Point(269, 57);
            this.studentStudentIDText.Size = new System.Drawing.Size(200, 20);
            this.studentStudentIDText.Text = "studentID";
            ///
            this.studentPersonnummerText.Location = new System.Drawing.Point(269, 80);
            this.studentPersonnummerText.Size = new System.Drawing.Size(100, 20);
            this.studentPersonnummerText.Text = "Personnummer";
            ///
            this.studentEmailText.Location = new System.Drawing.Point(269, 120);
            this.studentEmailText.Size = new System.Drawing.Size(100, 20);
            this.studentEmailText.Text = "Email";
            ///
            this.studentTelNrText.Location = new System.Drawing.Point(269, 150);
            this.studentTelNrText.Size = new System.Drawing.Size(100, 20);
            this.studentTelNrText.Text = "Telefonnummer";
            ///
         /*   this.personalLararLagsIDText.Location = new System.Drawing.Point(169, 170);
            this.personalLararLagsIDText.Size = new System.Drawing.Size(100, 20);
            this.personalLararLagsIDText.Text = "LärarlagsID"; */
            ///
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Size = new System.Drawing.Size(120, 300);
            this.button1.Location = new System.Drawing.Point(180, 210);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Text = "Lägg till";
            this.button2.Text = "Ta bort";
            this.button2.Location = new System.Drawing.Point(180, 250);
            this.button2.Size = new System.Drawing.Size(75, 23);
            ///this.button1.Location = new System.Drawing.Point(180, 250);
            ///this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Click += new System.EventHandler(this.button3_Click);
            this.button2.Click += new System.EventHandler(this.Delete_Click);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.button2.Click += new System.EventHandler(Delete_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.studentNamnText);
            this.Controls.Add(this.studentPersonalIDText);
            this.Controls.Add(this.studentPersonnummerText);
            this.Controls.Add(this.studentEmailText);
            this.Controls.Add(this.studentTelNrText);
            this.Controls.Add(this.studentKlassIDText);
            this.Text = "Lägg till student";
            this.Load += new EventHandler(Form1_Load);

            //
            // LaborationNamnText;  LaborationKursText;
            //LaborationKlassText;
            //listBox7;
            // button5;
            // button6;

            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.LaborationNamnText = new System.Windows.Forms.TextBox();
            this.LaborationKursText = new System.Windows.Forms.TextBox();
            this.LaborationKlassText = new System.Windows.Forms.TextBox();

            this.listBox7 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LaborationNamnText.Location = new System.Drawing.Point(369, 26);
            this.LaborationNamnText.Size = new System.Drawing.Size(500, 20);
            this.LaborationNamnText.Text = "LaborationNamn";
            ///
            this.LaborationKursText.Location = new System.Drawing.Point(369, 80);
            this.LaborationKursText.Size = new System.Drawing.Size(100, 20);
            this.LaborationKursText.Text = "LaborationKurs";
            ///
            this.LaborationKlassText.Location = new System.Drawing.Point(369, 120);
            this.LaborationKlassText.Size = new System.Drawing.Size(100, 20);
            this.LaborationKlassText = "LaborationsKlass";
            ///

            ///
         /*   this.personalLararLagsIDText.Location = new System.Drawing.Point(169, 170);
            this.personalLararLagsIDText.Size = new System.Drawing.Size(100, 20);
            this.personalLararLagsIDText.Text = "LärarlagsID"; */
            ///
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(12, 12);
            this.listBox7.Size = new System.Drawing.Size(120, 300);
            this.button5.Location = new System.Drawing.Point(180, 210);
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.Text = "Lägg till";
            this.button6.Text = "Ta bort";
            this.button6.Location = new System.Drawing.Point(180, 250);
            this.button6.Size = new System.Drawing.Size(75, 23);
            ///this.button1.Location = new System.Drawing.Point(180, 250);
            ///this.button1.Size = new System.Drawing.Size(75, 23);
            this.button5.Click += new System.EventHandler(this.button1_Click);
            this.button6.Click += new System.EventHandler(this.Delete_Click);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.button2.Click += new System.EventHandler(Delete_Click);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.LaborationNamnText);
            this.Controls.Add(this.LaborationKursText);
            this.Controls.Add(this.LaborationKlassText);
            this.Text = "Lägg till laboration";
            this.Load += new EventHandler(Form1_Load);



        }

        #region childform
        /// <summary>
        /// Gör detta till en childform
        /// </summary>
        private static Kurs m_SChildform;
        public static Kurs GetChildInstance3()
        {
            if (m_SChildform == null) //if not created yet, Create an instance

                m_SChildform = new Kurs();
            return m_SChildform;  //just created or created earlier.Return it

        }

        #endregion

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        //


        #endregion

        void Form1_Load(object sender, EventArgs e)
        {
            InitializeLararLista();
            listBox1.DataSource = Kurser;
            listBox1.DisplayMember = "Lägg till/Ta Bort Lärare";
            Kurser.AddingNew += new AddingNewEventHandler(Kurs_AddingNew);
            Kurser.ListChanged += new ListChangedEventHandler(Kurs_ListChanged);
            // lararLista.RemoveLarare += new AddingNewEventHandler(Delete_Click);
        }

        private void Kurs_ListChanged(object sender, ListChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Kurs_AddingNew(object sender, AddingNewEventArgs e)
        {
            throw new NotImplementedException();
        }


        // Declare a new BindingListOfT with the Part business object.
        BindingList<Kurs> Kurser;



        private void InitializeLararLista()
        {

            Kurser = new BindingList<>(Kurs);

            Kurser.AllowNew = true;
            Kurser.AllowRemove = true;


            Kurser.RaiseListChangedEvents = true;


            Kurser.AllowEdit = false;


            //   lararLista.Add(new Larare("Rasmus", "123", "198911224130", "Rasmus@HS.se", "0704554488"));

        }


        void Larare_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Larare(LararNamnText, int.Parse(LararPersonalIDText.Text), long.Parse(LararPersonnummerText.Text),
                LararEmailText, int.Parse(LararTelNrText.Text));

        }

        void Student_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Student(StudentNamnText, int.Parse(StudentPersonalIDText.Text), long.Parse(StudentPersonnummerText.Text),
                StudentEmailText, int.Parse(StudentTelNrText.Text));

        }


        void Laboration_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Laboration(LaborationsNamnText, LaborationsKursText, int.Parse(LaborationKlassText));

        }


        // Add the new part unless the part number contains
        // spaces. In that case cancel the add.
        private void button1_Click(object sender, EventArgs e)
        {
            Larare larare = Kurser.AddNew();

            lararNamnText.Text = lararNamnText.ToString();

            //  personalNamnText.Text = personalNamnText.ToString();

            ///ToString(personalNamnText) = "hej";

            int.Parse(lararLararIDText.Text);

            long.Parse(lararPersonnummerText.Text);
            lararEmailText.Text = lararEmailText.ToString();
            int.Parse(lararTelNrText.Text);


        }


        private void button3_Click(object sender, EventArgs e)
        {
            Student student = Kurser.AddNew();

            studentNamnText.Text = studentNamnText.ToString();

            //  personalNamnText.Text = personalNamnText.ToString();

            ///ToString(personalNamnText) = "hej";

            int.Parse(studentKlassIDText.Text);

            long.Parse(studentPersonnummerText.Text);
            studentEmailText.Text = studentEmailText.ToString();
            int.Parse(studentTelNrText.Text);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Laboration laboration = Kurser.AddNew();

            LaborationNamnText.Text = LaborationNamnText.ToString();

            //  personalNamnText.Text = personalNamnText.ToString();

            ///ToString(personalNamnText) = "hej";

            int.Parse(LaborationKlassText.Text);


            LaborationKursText = LaborationKursText.ToString();



        }





        void kurser_ListChanged(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Kurser.Clear();



            /*
            public Kurs()
            {
                InitializeComponent();
            }*/
        }
}
