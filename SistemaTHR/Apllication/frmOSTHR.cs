using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmOSTHR : Form
    {
        DataTable dt = new DataTable();
        public frmOSTHR()
        {
            InitializeComponent();
        }

        private void frmOSTHR_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", dt));



            this.reportViewer1.RefreshReport();
        }
    }
}
