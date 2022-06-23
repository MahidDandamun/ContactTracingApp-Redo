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
            if (((txtbxAddress.Text != "") && (txtbxFname.Text != "") && (txtbxEmail.Text != "") && (txtbxAge.Text != "")) &&
               ((txtbxContact.Text != "")  && (txtbxTemp.Text != "") && (txtbxTime.Text != "")) &&
               (txtbxZip.Text != ""))
            {
                btnNext.Enabled = true;
                pnl1.Visible = false;
                btnNext.Visible = false;
                btnReturn.Visible = true;
                btnSubmit.Visible = true;
                pnl2.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill in the fields");
            }
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
            if (((rdbtn1.Checked !=false) || (rdbtn2.Checked != false)) && 
                ((rdbtn3.Checked != false) || (rdbtn4.Checked != false)) && 
                ((rdbtn5.Checked != false) || (rdbtn6.Checked != false)) && 
                ((rdbtn7.Checked != false) || (rdbtn8.Checked != false)) && 
                ((rdbtn9.Checked != false) || (rdbtn10.Checked != false)) && 
                ((rdbtn11.Checked != false) || (rdbtn12.Checked != false)) && 
                ((rdbtn13.Checked != false) || (rdbtn14.Checked != false)) && 
                ((rdbtn15.Checked != false) || (rdbtn16.Checked != false)) && 
                ((rdbtn17.Checked != false) || (rdbtn18.Checked != false)))
            {
                StreamWriter file = new StreamWriter(@"E:\Downloads\Contact persons.txt", true);
                file.WriteLine("-------------------------------------------------------------------------------------------------------------------------" + " | ");
                file.WriteLine("Fullname: " + txtbxFname.Text + " | " + " Address: " + txtbxAddress.Text + " | " + " Time of visit: " + txtbxTime.Text + " | ");
                file.WriteLine("-------------------------------------------------------------------------------------------------------------------------" + " | ");
                file.WriteLine("Email: " + txtbxEmail.Text + " | " + " Contact number: " + txtbxContact.Text + " | " + " Date of visit: "  + " | ");
                file.WriteLine("-------------------------------------------------------------------------------------------------------------------------" + " | ");
                file.WriteLine("Zip code: " + txtbxZip.Text + " | " + " Age: " + txtbxAge.Text + " | " + " Temperature: " + txtbxTemp.Text);
                file.WriteLine("-------------------------------------------------------------------------------------------------------------------------" + " | ");
                if (rdbtn1.Checked)
                {
                    file.WriteLine("Question1: This person is having  difficulty in breathing");
                }
                else if (rdbtn2.Checked)
                {
                    file.WriteLine("Question1: NO");
                }
                if (rdbtn3.Checked)
                {
                    file.WriteLine("Question2: This person have lost his sense of taste and smell");
                }
                else if (rdbtn4.Checked)
                {
                    file.WriteLine("Question2: NO");
                }
                if (rdbtn5.Checked)
                {
                    file.WriteLine("Question3: This person have sore throat");
                }
                else if (rdbtn6.Checked)
                {
                    file.WriteLine("Question3: NO");
                }
                if (rdbtn7.Checked)
                {
                    file.WriteLine("Question4: This person have fever and chills");
                }
                else if (rdbtn8.Checked)
                {
                    file.WriteLine("Question4: NO");
                }
                if (rdbtn9.Checked)
                {
                    file.WriteLine("Question5: This person have diarrhea");
                }
                else if (rdbtn10.Checked)
                {
                    file.WriteLine("Question5: NO");
                }
                if (rdbtn11.Checked)
                {
                    file.WriteLine("Question6: This person have experienced having nausea and vomiting ");
                }
                else if (rdbtn12.Checked)
                {
                    file.WriteLine("Question6: NO");
                }
                if (rdbtn13.Checked)
                {
                    file.WriteLine("Question7: This person have been exposed to a covid-19 patient");
                }
                else if (rdbtn14.Checked)
                {
                    file.WriteLine("Question7: NO");
                }
                if (rdbtn15.Checked)
                {
                    file.WriteLine("Question8: This person have travel history to another countries");
                }
                else if (rdbtn16.Checked)
                {
                    file.WriteLine("Question8: NO");
                }
                if (rdbtn17.Checked)
                {
                    file.WriteLine("Question9: This person have received two doses of Covid Vaccine");
                }
                else if (rdbtn18.Checked)
                {
                    file.WriteLine("Question9: No");
                }
                file.Close();
                btnAnotherOne.Visible = true;
                btnSubmit.Visible = false;
                btnReturn.Visible = false;
                pnl2.Visible = false;
                pnl1.Visible = false;
                MessageBox.Show("Your response has been recorded");

            }
            else
            {
                MessageBox.Show("Answer the questions completely!");    
            }
        }

        private void btnAnotherOne_Click(object sender, EventArgs e)
        {
            txtbxAddress.Text = "";
            txtbxAge.Text = "";
            txtbxContact.Text = "";
            
            txtbxEmail.Text = "";
            txtbxFname.Text = "";
            txtbxTemp.Text = "";
            txtbxTime.Text = "";
            txtbxZip.Text = "";

            rdbtn1.Checked = false;
            rdbtn2.Checked = false;
            rdbtn3.Checked = false;
            rdbtn4.Checked = false;
            rdbtn5.Checked = false;
            rdbtn6.Checked = false;
            rdbtn7.Checked = false;
            rdbtn8.Checked = false;
            rdbtn9.Checked = false;
            rdbtn10.Checked = false;
            rdbtn11.Checked = false;
            rdbtn12.Checked = false;
            rdbtn13.Checked = false;
            rdbtn14.Checked = false;
            rdbtn15.Checked = false;
            rdbtn16.Checked = false;
            rdbtn17.Checked = false;
            rdbtn18.Checked = false;

            pnl1.Visible = true;
            btnAnotherOne.Visible=false;
            btnNext.Visible = true;
        }
    }
}
