using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft.CommForms
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            try
            {
                transparent_panel();
                //-------------------

                //----------------------------
                this.appUsersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                this.appUsersTableAdapter1.Fill(this.letters1.AppUsers);
                //------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
        }

    

        void transparent_panel()
        {
            this.panel2.BackColor = Color.FromArgb(70, Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //------------------------
            if (this.user_name_comboBox1.SelectedIndex==-1)
            {
                System.Windows.Forms.MessageBox.Show("Please select the uset first!");
                return;
            }
            //------------------------
            if (this.user_pass_textBox2.Text!=this.correct_textBox1.Text)
            {
                System.Windows.Forms.MessageBox.Show("Please enter the correct password!");
                return;
            }
            //-------------------
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void sett_button1_Click(object sender, EventArgs e)
        {
            Secretariat_Soft.CommForms.SQL_Settings frm = new SQL_Settings();
            frm.ShowDialog();
        }
    }
}
