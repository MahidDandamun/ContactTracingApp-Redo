using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_tracing_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            btnNext.Visible = false;
            btnReturn.Visible = true;
            btnSubmit.Visible = true;
            pnl2.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            btnSubmit.Visible=false;
            btnNext.Visible=true;
            btnReturn.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"E\Downloads\test.txt");

            file.Close();
            MessageBox.Show("Thanks for Cooperation");
        }
    }
}
