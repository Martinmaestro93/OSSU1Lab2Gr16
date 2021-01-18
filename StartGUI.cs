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
    public partial class StartGUI : Form
    {
        public StartGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Skapar en childform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void läggTillTaBortLärareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HogskolanGUI objfrmHome = HogskolanGUI.GetChildInstance();
            objfrmHome.MdiParent = this;
            objfrmHome.WindowState = FormWindowState.Maximized;
            objfrmHome.Show();
            objfrmHome.BringToFront();
        }

        private void hanteraLärarlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lararlagform objfrmHome = Lararlagform.GetChildInstance2();
            objfrmHome.MdiParent = this;
            objfrmHome.WindowState = FormWindowState.Maximized;
            objfrmHome.Show();
            objfrmHome.BringToFront();
        }

        private void hanteraKurserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kurs objfrmHome = Kurs.GetChildInstance3();
            objfrmHome.MdiParent = this;
            objfrmHome.WindowState = FormWindowState.Maximized;
            objfrmHome.Show();
            objfrmHome.BringToFront();
        }

        private void läggTillStudenterToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Studerande objfrmHome = Studerande.GetChildInstance4();
            objfrmHome.MdiParent = this;
            objfrmHome.WindowState = FormWindowState.Maximized;
            objfrmHome.Show();
            objfrmHome.BringToFront();
        }
    }
}
