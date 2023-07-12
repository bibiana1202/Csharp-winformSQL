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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            //------------------------
            object_perm_loader();
            //------------------------
            try
            {
                //-------------
                this.appUsersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.appUsersTableAdapter1.Fill(this.letters1.AppUsers);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //--------------------------------
           
        }
        void object_perm_loader()
        {
            Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
            //-----------load the permissions by col name -----------------
            this.add_butt.Enabled = MyClass.get_permission_by_col_name("User_List_b1");// add
            //-------------------------------------------------------------
            if (Secretariat_Soft.Properties.Settings.Default.User_Id == Secretariat_Soft.Properties.Settings.Default.admin_user_id)
            {
               this.add_butt.Enabled = true;
            }
            //-------------------------------------------------------------
        }
        private void add_butt_Click(object sender, EventArgs e)
        {
            try
            {
                Secretariat_Soft.CommForms.Users_de frm = new Users_de();
                frm.id_label5.Text = this.id_label5.Text;
                frm.ShowDialog();
                //--------------------
                //-------------
                this.appUsersTableAdapter1.Connection.ConnectionString = Secretariat_Soft.MyClasses.ComClass.MyConn_String;
                //-------------
                this.appUsersTableAdapter1.Fill(this.letters1.AppUsers);
                //------------------------
                //============Reload permission data ====================
                Secretariat_Soft.MyClasses.ComClass MyClass = new MyClasses.ComClass();
                MyClass.user_perm_loader_from_db();
                 //======================================================= 

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //--------------------
        }

        private void UserList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (this.add_butt.Enabled == true)
                    {
                        add_butt_Click(sender, e);
                    }
                    //-------
                    break;
 
                default:
                    break;
            }
        }
    }
}
