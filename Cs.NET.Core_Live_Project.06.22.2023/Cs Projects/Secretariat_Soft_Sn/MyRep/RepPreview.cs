using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRep
{
    public partial class RepPreview : Form
    {
        public RepPreview()
        {
            InitializeComponent();
        }

        private void RepPreview_Load(object sender, EventArgs e)
        {
            string rep_fn,rpt_name, xml_fn;
            MyRep.Ds.Letters letters_ds = new Ds.Letters();
            //-----------------
            rpt_name = Environment.GetCommandLineArgs()[1];//0 -> file name , 1= first param
            rep_fn = Application.StartupPath + "\\Data\\Reps\\"+rpt_name;
            //MessageBox.Show(rpt_name);
            //---------------
            //---------------
            xml_fn = Application.StartupPath + "\\Data\\Reps\\help.mp3";
            //-----
            if (System.IO.File.Exists(xml_fn)==true)
            {
                letters_ds.ReadXml(xml_fn);
            }
            //---------------
            //this.dataGridView1.DataSource = letters_ds;
            //this.dataGridView1.DataMember = "Sa_In_Letters";
            //---------------
            this.reportDocument1.Load(rep_fn);
            this.reportDocument1.SetDataSource(letters_ds);
            //----------------
            this.crystalReportViewer1.ReportSource = this.reportDocument1;
            this.crystalReportViewer1.RefreshReport();
            //----------------
        }
    }
}
