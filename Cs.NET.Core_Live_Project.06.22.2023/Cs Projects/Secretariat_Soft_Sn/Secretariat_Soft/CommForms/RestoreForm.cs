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
    public partial class RestoreForm : Form
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void exit_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restore_button2_Click(object sender, EventArgs e)
        {
            if (this.file_name_textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("File name is not Valid!");
                return;
            }
            //=======================================================
            //--------file size checker -----------------------------

            long fs ;
            string err_msg;
            err_msg = "";
            try
            {
                System.IO.FileInfo fi = new FileInfo(this.file_name_textBox1.Text);
                fs = fi.Length;
                //----------
            }
            catch (Exception ex)
            {
                fs = -1;
                err_msg = ex.Message;
            }
           //------------------------
           
            if (fs <= 0)// invalid Backup file!
            {
                System.Windows.Forms.MessageBox.Show("Error! invalid Backup file! " + err_msg);
                return;
            }

            //-------------------------------------------------------
            //===================db exist checker ===================
            Secretariat_Soft.Ds.LettersTableAdapters.AppUsersTableAdapter ta=new Ds.LettersTableAdapters.AppUsersTableAdapter();
            Secretariat_Soft.Ds.Letters ds = new Ds.Letters();
            //-----------
            
            try
            {
                //-------------
                ta.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                ta.FillBy_db_exist_checker(ds.AppUsers);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! Can't get access to your SQL database: " + ex.Message);
                return;
            }
            //=======================================================
            //------------------------
            this.prog_panel4.Show();
            this.prog_panel4.Refresh();
            //------
            this.restore_button2.Enabled = false;
            this.restore_button2.Refresh();
            //------------------------
            string con_string;
            con_string = Secretariat_Soft.MyClasses.ComClass.MyConn_String; //@"Data Source=MY-PC\SQL_EX_2019;Initial Catalog=CsApps;Persist Security Info=True;User ID=sa;Password=123";
            //-------
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con_string);
            //===========================
            System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand();
            sqlCommand.Connection = conn;
            //===========================
            try
            {
                sqlCommand.CommandTimeout = 20;
                conn.Open();
                //---------------
                string restore_query_text;

                //-----------------
                restore_query_text = "USE [master] " +
                      " ALTER DATABASE [CsApps] SET SINGLE_USER WITH ROLLBACK IMMEDIATE" +
                      " RESTORE DATABASE [CsApps] "+
                      " FROM  DISK = N'"+this.file_name_textBox1.Text+"' " +
                      " WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5 " +
                      " ALTER DATABASE [CsApps] SET MULTI_USER";
                //-----------------------
                sqlCommand.CommandText = restore_query_text;
                sqlCommand.ExecuteNonQuery();
                //---------------
                conn.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!. " + ex.Message);
            }
            //------------------------
            this.prog_panel4.Hide();
            this.prog_panel4.Refresh();
            //------
            this.restore_button2.Enabled = true;
            this.restore_button2.Refresh();
            //------------------------
            //
            System.Windows.Forms.MessageBox.Show("Restoration done!");
        }

        private void browse_button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //---------------
            DialogResult dr;
            //---filter----
            dlg.Filter = "Backup Files|*.s22";
            //-------------
            dr = dlg.ShowDialog();
            //-----------
            if (dr == DialogResult.OK)
            {
                string fn;
                fn = dlg.FileName;
                //--------
                this.file_name_textBox1.Text = fn;
            }
        }
    }
}
