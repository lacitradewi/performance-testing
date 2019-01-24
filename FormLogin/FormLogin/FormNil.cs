using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace FormLogin
{
    public partial class FormNil : Form
    {
        public FormNil(ReportClass rpt)
        {
            InitializeComponent();
            InitializeReport(rpt);
        }

        private void InitializeReport(ReportClass rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(0);
        }

        private void FormNil_Load(object sender, EventArgs e)
        {

        }
    }
}
