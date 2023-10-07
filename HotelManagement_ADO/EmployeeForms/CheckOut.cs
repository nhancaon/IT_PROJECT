using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using HotelManagement_ADO.DB_Layer;

namespace HotelManagement_ADO.EmployeeForms
{
    public partial class CheckOut : Form
    {
        int rAvai;
        int currentCustomerID;
        int currentBookingID;

        DBMain database = null;
        Receipt formReceipt = null;
        public CheckOut()
        {
            InitializeComponent();
            database = new DBMain();
            LoadCustomer();
        }

        void LoadCustomer()
        {

 
            string nameToFind = txtFindName.Text;
        
            DataTable dataTable = null;
            if (string.IsNullOrEmpty(nameToFind))
            {
                var view = database.ExecuteQueryDataSet("SELECT * FROM View_CustomerCheckOut", CommandType.Text);
                dataTable = view.Tables[0];
            }
            else
            {
                var query = $"SELECT * FROM FindCustomerByFullName(N'{nameToFind}')";

                var view = database.ExecuteQueryDataSet(query, CommandType.Text);
                dataTable = view.Tables[0];
            }

            dgvCustomer.DataSource = dataTable;
            dgvCustomer.AutoGenerateColumns = true;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.Columns[0].HeaderText = "Booking ID";
            dgvCustomer.Columns[1].HeaderText = "Customer ID";
            dgvCustomer.Columns[2].HeaderText = "Customer Name";
            dgvCustomer.Columns[3].HeaderText = "Identify Number";
            dgvCustomer.Columns[4].HeaderText = "Phone Number";
            dgvCustomer.Columns[5].HeaderText = "Room Number";
            dgvCustomer.Columns[6].HeaderText = "Check In Date";
            dgvCustomer.Columns[7].HeaderText = "Check Out Date";
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
           if(currentCustomerID != 0)
           {
                var checkOutDataSet = database.ExecuteQueryDataSet($"Select * from GetCustomerReceipt('{currentBookingID}', '{currentCustomerID}')", CommandType.Text);
                //Console.WriteLine(checkOutDataSet);
                formReceipt = new Receipt();
                formReceipt.currentCustomerID = currentCustomerID;
                formReceipt.dataSet = checkOutDataSet;
                formReceipt.LoadReceipt();

                formReceipt.TopLevel = false;
                formReceipt.FormBorderStyle = FormBorderStyle.None;
                formReceipt.Dock = DockStyle.Fill;
                receptPanel.Controls.Add(formReceipt);
                receptPanel.Tag = formReceipt;
                receptPanel.BringToFront();
                formReceipt.BringToFront();
                closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
                closeBtn.BringToFront();
                formReceipt.Show();
           }
     
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            formReceipt.Close();
            closeBtn.SendToBack();
            closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            receptPanel.SendToBack();


        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rAvai = dgvCustomer.CurrentCell.RowIndex;
            this.txtCName.Text = dgvCustomer.Rows[rAvai].Cells[1].Value.ToString();
            this.txtRoom.Text = dgvCustomer.Rows[rAvai].Cells[5].Value.ToString();
            currentBookingID = Convert.ToInt32(dgvCustomer.Rows[rAvai].Cells[0].Value);
            currentCustomerID = Convert.ToInt32(dgvCustomer.Rows[rAvai].Cells[1].Value);
            DateTime checkIn = DateTime.Parse(dgvCustomer.Rows[rAvai].Cells[6].Value.ToString());
            DateTime checkOut = DateTime.Parse(dgvCustomer.Rows[rAvai].Cells[7].Value.ToString());
            TimeSpan duration = checkOut - checkIn;
            this.txtStayingDays.Text = duration.Days.ToString() + " Days";
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
