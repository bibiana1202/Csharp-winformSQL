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
    public partial class SQL_Settings : Form
    {
        public SQL_Settings()
        {
            InitializeComponent();
        }

      
        private void exit_button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
        }

        private void backup_button2_Click(object sender, EventArgs e)
        {
            //----------save in app settings-----------
            string cs,cs_enct;
            cs = con_generator();
            //---------
            cs_enct = NETCore.Encrypt.EncryptProvider.AESEncrypt(cs,Secretariat_Soft.MyClasses.ComClass.dfftrf );
            //---------
            Secretariat_Soft.Properties.Settings.Default.main_con_text = cs_enct;
            Secretariat_Soft.Properties.Settings.Default.is_sql_auth = this.sql_radioButton2.Checked;
            //---------
            Secretariat_Soft.Properties.Settings.Default.Save();
            //-----------------------------------------
            this.DialogResult = DialogResult.OK;
        }

        string con_generator()
        {
            //Data Source=MY-PC\SQL_EX_2019;Initial Catalog=CsApps;Integrated Security=True
            //Data Source=MY-PC\SQL_EX_2019;Initial Catalog=CsApps;Persist Security Info=True;User ID=sa;Password=123
            string MyCon = "";
            if (this.win_radioButton1.Checked == true)//Win Auth
            {
                MyCon = "Data Source=" + this.server_name_textBox1.Text +
                        ";Initial Catalog=" + this.db_name_textBox1.Text +
                        ";Integrated Security=True";
            }
            else// SQL Auth
            {
                MyCon = "Data Source=" + this.server_name_textBox1.Text +
                       ";Initial Catalog=" + this.db_name_textBox1.Text +
                       ";Persist Security Info=True;User ID=" + this.user_name_textBox2.Text +
                       ";Password=" + this.pass_textBox3.Text;
            }
            //----------------
            return MyCon;
        }
        private void SQL_Settings_Load(object sender, EventArgs e)
        {
            //Data Source=MY-PC\SQL_EX_2019;Initial Catalog=CsApps;Integrated Security=True
            //Data Source=MY-PC\SQL_EX_2019;Initial Catalog=CsApps;Persist Security Info=True;User ID=sa;Password=123

            this.auth_panel1.Visible = false;
            //====================
            bool is_sql_auth = false;
            //--------
            is_sql_auth = Secretariat_Soft.Properties.Settings.Default.is_sql_auth;
            
            //----load con string---------------
            string MyCon;
            MyCon = Secretariat_Soft.Properties.Settings.Default.main_con_text;
            //----------
            MyCon=NETCore.Encrypt.EncryptProvider.AESDecrypt(MyCon, Secretariat_Soft.MyClasses.ComClass.dfftrf);
            //----------
            string[] con_parts;
            string[] final_parts;
            string MyData;
            //-------
            con_parts = MyCon.Split(";");
            //-------------server name seperator ---------------------
            MyData=con_parts[0];// Data Source=MY-PC\SQL_EX_2019
            //------
            final_parts=MyData.Split("=");
            this.server_name_textBox1.Text = final_parts[1];
            //-----------------------------------------------------------
            //-------------database name seperator ---------------------
            MyData = con_parts[1];// Initial Catalog=CsApps
            //------
            final_parts = MyData.Split("=");
            this.db_name_textBox1.Text = final_parts[1];
            //-----------------------------------------------------------
            if (is_sql_auth==true)
            {
                //-------------user name seperator ---------------------
                MyData = con_parts[3];// User ID=sa; 
                //------
                final_parts = MyData.Split("=");
                this.user_name_textBox2.Text = final_parts[1];
                //-----------------------------------------------------------
                //-------------password seperator ---------------------
                MyData = con_parts[4];//  Password=123
                //------
                final_parts = MyData.Split("=");
                this.pass_textBox3.Text = final_parts[1];
                //-----------------------------------------------------------
            }
            //------------
            this.sql_radioButton2.Checked = is_sql_auth;
            //------------
        }

        private void sql_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.auth_panel1.Visible = this.sql_radioButton2.Checked;
        }

        private void test_button1_Click(object sender, EventArgs e)
        {
            string MyCon;
            MyCon = con_generator();
            //------------------------
            //===================db exist checker ===================
            Secretariat_Soft.Ds.LettersTableAdapters.AppUsersTableAdapter ta = new Ds.LettersTableAdapters.AppUsersTableAdapter();
            Secretariat_Soft.Ds.Letters ds = new Ds.Letters();
            //-----------
            this.prog_panel4.Visible = true;
            this.prog_panel4.Refresh();
            //------------
            try
            {
                ta.Connection.ConnectionString =MyCon;
                ta.FillBy_db_exist_checker(ds.AppUsers);
                //------------
                //-----------
                this.prog_panel4.Visible = false;
                this.prog_panel4.Refresh();
                //------------
                System.Windows.Forms.MessageBox.Show("Test connection succeded!"  );
                //------------
            }
            catch (Exception ex)
            {
                //-----------
                this.prog_panel4.Visible = false;
                this.prog_panel4.Refresh();
                //------------
                System.Windows.Forms.MessageBox.Show("Error! Can't get access to your SQL database: " + ex.Message);
                return;
            }
            //=======================================================
        }
    }
}
