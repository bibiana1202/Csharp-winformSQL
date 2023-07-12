using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat_Soft.MyClasses
{
    public class ComClass
    {
        static Secretariat_Soft.Ds.Letters.AppUsersDataTable user_perm_dt = new Ds.Letters.AppUsersDataTable();
        public static string dfftrf = "aserdlkjhy2340!@(*&^%$FVDCL.?;lh";
        public static string MyConn_String = "";
        public void user_perm_loader_from_db()
        {
            try
            {
                //-------------------------
                Secretariat_Soft.Ds.LettersTableAdapters.AppUsersTableAdapter ta = new Ds.LettersTableAdapters.AppUsersTableAdapter();
                //-------------------------
                Int32 uid;
                uid = (Int32)Secretariat_Soft.Properties.Settings.Default.User_Id;
                //-------------
                ta.Connection.ConnectionString =  MyConn_String;
                //-------------
                ta.FillBy_login_user_id(user_perm_dt, uid);
                //-------------------------
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error! " + ex.Message);
            }
            //------------------------
           
        }

        public bool get_permission_by_col_name(string column_name)
        {
            bool r;
            r = (bool)user_perm_dt.Rows[0][column_name];
             //-----------------
             return r;
        }
    }
}
