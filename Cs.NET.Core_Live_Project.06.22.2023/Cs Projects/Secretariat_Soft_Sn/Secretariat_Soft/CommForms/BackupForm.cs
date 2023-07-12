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
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browse_button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr=this.folderBrowserDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                string fn,d ;
                d = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
                fn = this.folderBrowserDialog1.SelectedPath +"\\"+ d + ".s22";
                //-----------
                this.file_name_textBox1.Text = fn;
                //-----------------
            }
        }

        private void backup_button2_Click(object sender, EventArgs e)
        {
            if (this.file_name_textBox1.Text=="")
            {
                System.Windows.Forms.MessageBox.Show("File name is not Valid!");
                return;
            }
            //------------------------
            this.prog_panel4.Show();
            this.prog_panel4.Refresh();
            //------
            this.backup_button2.Enabled = false;
            this.backup_button2.Refresh();
            //------------------------
            string con_string;
            con_string = Secretariat_Soft.MyClasses.ComClass.MyConn_String; //@"Data Source=MY-PC\SQL_EX_2019;Initial Catalog=CsApps;Persist Security Info=True;User ID=sa;Password=123";
            //-------
            System.Data.SqlClient.SqlConnection conn=new System.Data.SqlClient.SqlConnection(con_string);
            //===========================
            System.Data.SqlClient.SqlCommand sqlCommand=new System.Data.SqlClient.SqlCommand();
            sqlCommand.Connection=conn;
            //===========================
            try
            {
                sqlCommand.CommandTimeout = 20;
                conn.Open();
                //---------------
                string backup_query_text;
                string fcomment;
                fcomment = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
                //-----------------
                backup_query_text = "BACKUP DATABASE [CsApps] "+
                      "TO DISK = N'"+this.file_name_textBox1.Text+ "' "+
                      "WITH NOFORMAT, INIT,"+
                      "NAME = N'My_backup_"+ fcomment + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                //-----------------------
                sqlCommand.CommandText = backup_query_text;
                sqlCommand.ExecuteNonQuery();
                //---------------
                conn.Close();
                   
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!. "+ex.Message) ;
            }
            //--------file size checker -----------------------------
           
            long fs,fs_KB;
            string err_msg;
            err_msg = "";
            try
            {
                System.IO.FileInfo fi = new FileInfo(this.file_name_textBox1.Text);
              
                fs= fi.Length;
                //----------
            }
            catch (Exception ex)
            {
                fs = -1;
                err_msg = ex.Message;
            }
            //----------

            //------------------------
            this.prog_panel4.Hide();
            this.prog_panel4.Refresh();
            //------
            this.backup_button2.Enabled = true;
            this.backup_button2.Refresh();
            //------------------------

            if (fs<=0)// Backup is failed!
            {
                System.Windows.Forms.MessageBox.Show("Error! Backup is failed! "+err_msg);
            }
            else// backup is done!
            {
                fs_KB = fs / 1024;
                System.Windows.Forms.MessageBox.Show("Backup is done! File size: " +fs_KB.ToString()+" KB");
            }
            //-------------------------------------------------------
          
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
