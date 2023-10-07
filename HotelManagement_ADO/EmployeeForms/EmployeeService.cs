using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement_ADO.BS_Layer;
using HotelManagement_ADO.DB_Layer;

namespace HotelManagement_ADO.EmployeeForms
{
    public partial class EmployeeService : Form
    {
        string err;
        int rAvai;
        int rBooked;
        int customerID = -1;
        int bookID = -1;
        string name;
      
        DBMain database = null;
        public EmployeeService()
        {
            InitializeComponent();
            database = new DBMain();

           LoadDataAvai();
            this.btnAddService.Enabled = false;


        }
        void LoadDataAvai()
        {
            var view = database.ExecuteQueryDataSet("Select * from View_AvailableProduct", CommandType.Text);
            DataTable dataTable = view.Tables[0];
            dgvAvaiServices.DataSource = dataTable;
            dgvAvaiServices.AutoGenerateColumns = true;
            dgvAvaiServices.ColumnHeadersHeight = 30;
            dgvAvaiServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvaiServices.Columns[0].HeaderText = "Product ID";
            dgvAvaiServices.Columns[1].HeaderText = "Product Name";
            dgvAvaiServices_CellClick(null, null);
        }

        void LoadDataBooked()
        {
            var proc = database.ExecuteQueryDataSet($"SELECT * FROM fn_FindServiceByName(N'{name}')", CommandType.Text);
            DataTable dataTable = proc.Tables[0];
            dataTable.Columns["SerID"].ColumnName = "Service ID";
            dataTable.Columns["FullName"].ColumnName = "Customer Name";
            dataTable.Columns["ProductName"].ColumnName = "Product Name";
            dataTable.Columns["Book_ID"].ColumnName = "Booking ID";
            // Create a DataView to filter and project the desired columns
            DataView dataView = new DataView(dataTable);
            dataView = new DataView(dataTable);
            dataView = new DataView(dataTable);
            dataView = new DataView(dataTable);
            dataView = new DataView(dataTable);
            dataView = new DataView(dataTable);
            dataView = new DataView(dataTable);

            // Set the Filter property to display only the desired columns
            dataView.Table = dataTable.DefaultView.ToTable(false, "Service ID", "Customer Name", "Product Name", "Booking ID", "Amount", "Price");
            
            dgvBookedServices.DataSource = dataView;
            dgvBookedServices.ColumnHeadersHeight = 30;
            customerID = ReturnCustomerID(txtName.Text);
            if (customerID != -1)
            {
                bookID = ReturnBookID(customerID);
                if (bookID != -1)
                {
                    txtBookID.Text = bookID.ToString();
                    this.btnAddService.Enabled = true;
                }
            }
            if (dataView.Count > 0)
            {
                dgvBookedServices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvBookedServices_CellClick(null, null);
                this.btnAddService.Enabled = true;
            }
            else
            {
                dataTable.Clear();
            }
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                BLService dbSE = new BLService();
                dbSE.AddService(Convert.ToInt32(this.txtBookID.Text), customerID, Convert.ToInt32(dgvAvaiServices.Rows[rAvai].Cells[0].Value.ToString()), Convert.ToDouble(dgvAvaiServices.Rows[rAvai].Cells[2].Value.ToString()), Convert.ToInt32(txtAmount.Text), DateTime.Now, ref err);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
            }
            LoadDataAvai();
            LoadDataBooked();
        }

        private void dgvAvaiServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rAvai = dgvAvaiServices.CurrentCell.RowIndex;
            this.txtNameProduct.Text = dgvAvaiServices.Rows[rAvai].Cells[1].Value.ToString();
        }
        int ReturnCustomerID(string name)
        {
            var dataSet = database.ExecuteQueryDataSet("SELECT * FROM Customers", CommandType.Text);
            var dataTable = dataSet.Tables[0];

            foreach (DataRow row in dataTable.Rows)
            {
                string fullName = row["Fullname"].ToString();
                int cID = Convert.ToInt32(row["cID"]);

                if (fullName == name)
                {
                    return cID;
                }
            }

            return -1;
        }
        int ReturnBookID(int cID)
        {
            var dataSet = database.ExecuteQueryDataSet("SELECT * FROM Booking", CommandType.Text);
            var dataTable = dataSet.Tables[0];

            foreach (DataRow row in dataTable.Rows)
            {
                int ID = Convert.ToInt32(row["customer_ID"]);

                if (ID == cID)
                {
                    return ID;
                }
            }

            return -1;
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                BLService dbSE = new BLService();
                dbSE.DeleteService(ref err, Convert.ToInt32(dgvBookedServices.Rows[rBooked].Cells[0].Value.ToString()));
                LoadDataAvai();
                LoadDataBooked();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
            }
        }

        private void dgvBookedServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rBooked = dgvBookedServices.CurrentCell.RowIndex;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtBookID.ResetText();
            this.btnAddService.Enabled = false;
            name = txtName.Text;
            LoadDataBooked();
        }
    }
}