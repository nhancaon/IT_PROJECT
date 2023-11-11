using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_ADO.ReportForm
{
    public partial class ReportRevenue : Form
    {
        public ReportRevenue()
        {
            InitializeComponent();
        }

        private void ReportRevenue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementSystemDataSet.MonthlySummary' table. You can move, or remove it, as needed.
            this.monthlySummaryTableAdapter.Fill(this.hotelManagementSystemDataSet.MonthlySummary);

            this.reportViewer1.RefreshReport();
        }
    }
}
