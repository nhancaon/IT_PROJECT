using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HotelManagement_ADO.DB_Layer;

namespace HotelManagement_ADO.EmployeeForms
{
    public partial class Receipt : Form
    {
        public int currentCustomerID { get; set; }
        public int currentBookingID { get; set; }
        public DataSet dataSet { get; set; }

        DBMain database;

        public Receipt()
        {
            InitializeComponent();
            database = new DBMain();
            listView1.View = View.Details;
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Scrollable = false;
            listView1.Columns.Add("Product Name", 170);
            listView1.Columns.Add("Product Price", 150);
            listView1.Columns.Add("Service Quantity", 100);
            listView1.Columns.Add("Service Total", 100);

        }

        public void LoadReceipt()
        {
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                DataTable table = dataSet.Tables[0];
                if (table.Rows.Count > 0)
                {

                    DataRow row = table.Rows[0];

                    txtCustomer.Text = row["CustomerName"].ToString();
                    txtCashier.Text = row["EmployeeName"].ToString();
                    txtCapacity.Text = $"{row["RoomCapacity"].ToString()} " +
                        $"{(Convert.ToInt32(row["RoomCapacity"]) == 1 ? "Person" : "People")}";
                    txtStayingDays.Text = row["StayingDays"].ToString() + " Days";
                    txtDate.Text = DateTime.Now.ToString();
                    txtRoomNumber.Text = row["room_No"].ToString();

                    // Add the product and service details to the ListView
                    foreach (DataRow serviceRow in table.Rows)
                    {
                        string productName = serviceRow["ProductName"].ToString();
                        decimal productPrice = Convert.ToDecimal(serviceRow["ProductPrice"]);
                        int serviceQuantity = Convert.ToInt32(serviceRow["ServiceQuantity"]);
                        decimal serviceTotal = Convert.ToDecimal(serviceRow["ServiceTotal"]);

                        ListViewItem item = new ListViewItem(productName);
                        item.SubItems.Add(productPrice.ToString());
                        item.SubItems.Add(serviceQuantity.ToString());
                        item.SubItems.Add(serviceTotal.ToString());

                        listView1.Items.Add(item);
                    }

                    // Add room booking item
                    decimal roomPrice = Convert.ToDecimal(row["RoomPrice"]);
                    int stayingDays = Convert.ToInt32(row["StayingDays"]);
                    decimal totalRoomBooking = roomPrice * stayingDays;

                    ListViewItem roomBookingItem = new ListViewItem($"Room {row["room_No"].ToString()}");
                    roomBookingItem.SubItems.Add(roomPrice.ToString());
                    roomBookingItem.SubItems.Add(stayingDays.ToString());
                    roomBookingItem.SubItems.Add(totalRoomBooking.ToString());

                    listView1.Items.Add(roomBookingItem);

                    decimal totalMoney = 0;

                    foreach (ListViewItem item in listView1.Items)
                    {
                        decimal serviceTotal = Convert.ToDecimal(item.SubItems[3].Text);
                        totalMoney += serviceTotal;
                    }
                    totalMoney += totalRoomBooking;

                    txtTotal.Text = totalMoney.ToString();


                }
            }
        }

    }
}