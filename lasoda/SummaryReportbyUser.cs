using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace lasoda
{
    public partial class SummaryReportbyUser : Form
    {
        public SummaryReportbyUser()
        {
            InitializeComponent();
        }

        private void SummaryReportbyUser_Load(object sender, EventArgs e)
        {
            //summarybyUser1.Load();
            crystalReportViewer1.Refresh();

        }
    }
}
