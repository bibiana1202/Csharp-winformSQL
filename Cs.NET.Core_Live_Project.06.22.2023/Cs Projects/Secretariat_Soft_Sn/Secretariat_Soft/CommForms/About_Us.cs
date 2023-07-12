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
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void About_Us_Load(object sender, EventArgs e)
        {
            this.Company_Name_label1.Text = Application.CompanyName;
            this.product_name_label1.Text=Application.ProductName;
            this.version_label1.Text = Application.ProductVersion;
            this.copy_right_label1.Text = copy_right_reader();
       
        }

        string? copy_right_reader()
        {
            string? fn = "";
            //--------------
            try
            {
                System.Reflection.Assembly? asm;
                asm = System.Reflection.Assembly.GetEntryAssembly();
                //-----------------
                if (asm != null)
                {
                    fn = asm.Location;
                }
                //---------------
                var ver_Info = System.Diagnostics.FileVersionInfo.GetVersionInfo(fn);
                //---------------
                return ver_Info.LegalCopyright;
            }
            catch (Exception)
            {
                return "Unknown";
            }

        }

    }
}
