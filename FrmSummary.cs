using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_tracing_app
{
    public partial class FrmSummary : Form
    
    {

        public FrmContacttracing originalform;
        List<string> contacts = new List<string>();
        List<ListViewItem>items= new List<ListViewItem>();
        List<DateTimePicker> recorddates = new List<DateTimePicker>();
        public FrmSummary()
        {
            InitializeComponent();
        }

        private void FrmSummary_Load(object sender, EventArgs e)
        {
            int count = lvRecords.Items.Count;
            lblPeopleCount.Text = ("There are " + count.ToString() +" Individuals Recorded");
        }
        private void frmsummary_close(object sender, FormClosingEventArgs e)
        {
            originalform.Close();
            this.Close();
        }

        
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
