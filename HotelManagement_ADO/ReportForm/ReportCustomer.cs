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
    public partial class ReportCustomer : Form
    {
        public ReportCustomer()
        {
            InitializeComponent();
        }

        private void ReportCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);

            this.reportViewer1.RefreshReport();
        }
    }
}
