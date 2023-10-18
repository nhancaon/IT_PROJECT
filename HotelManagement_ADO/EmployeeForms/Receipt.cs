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

        public Receipt()
        {
            InitializeComponent();
            listviewReceipt.View = View.Details;
            listviewReceipt.HeaderStyle = ColumnHeaderStyle.None;
            listviewReceipt.Scrollable = false;
            #region Resize column in listView
            listviewReceipt.Columns.Add("Title", 170);
            listviewReceipt.Columns.Add("Price", 110);
            listviewReceipt.Columns.Add("Amount", 120);
            listviewReceipt.Columns.Add("Subtotal", 100);
            #endregion
        }

        public void LoadReceipt()
        {
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                DataTable table = dataSet.Tables[0];
 
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    string head;

                    #region Customer infor and some details
                    txtCustomer.Text = row["CustomerName"].ToString();
                    txtCashier.Text = row["EmployeeName"].ToString();
                    txtcusAmount.Text = $"{row["NumberofCustomers"].ToString()} " +
                                        $"{(Convert.ToInt32(row["NumberofCustomers"]) == 1 ? "Person" : "People")}";
                    txtStayingDays.Text = row["StayingDays"].ToString() + (Convert.ToInt32(row["StayingDays"]) == 1 ? " Day" : " Days");
                    txtDate.Text = DateTime.Now.ToString();
                    txtRoomNumber.Text = row["RoomNumber"].ToString();
                    txtTotal.Text = row["TotalPrice"].ToString() + " VND";
                    #endregion

                    // Add room booking info
                    #region Calculate room fee
                    head = "- Room Fee:";
                    ListViewItem roomfee = new ListViewItem(head);
                    listviewReceipt.Items.Add(roomfee);

                    decimal roomPrice = Convert.ToDecimal(row["RoomPrice"]);
                    int stayingDays = Convert.ToInt32(row["StayingDays"]);
                    decimal totalRoomBooking = Convert.ToDecimal(row["RoomTotal"]);

                    ListViewItem roomBookingItem = new ListViewItem($"{row["RoomType"].ToString()}");
                    roomBookingItem.SubItems.Add(roomPrice.ToString());
                    roomBookingItem.SubItems.Add(stayingDays.ToString() + (Convert.ToInt32(row["StayingDays"]) == 1 ? " Day" : " Days"));
                    roomBookingItem.SubItems.Add(totalRoomBooking.ToString());

                    listviewReceipt.Items.Add(roomBookingItem);
                    #endregion

                    if (Convert.ToString(row["ServiceName"]) != "")
                    {
                        if(Convert.ToString(row["DamagedItem"]) != "")
                        {
                            // Add service detail info
                            #region Calculate service fee iff damaged null
                            head = "- Service Fee:";
                            ListViewItem serfee = new ListViewItem(head);
                            listviewReceipt.Items.Add(serfee);

                            foreach (DataRow serviceRow in table.Rows)
                            {
                                string serviceName = serviceRow["ServiceName"].ToString();
                                decimal servicePrice = Convert.ToDecimal(serviceRow["ServicePrice"]);
                                int serviceQuantity = Convert.ToInt32(serviceRow["NumberofUsers"]);
                                decimal serviceTotal = Convert.ToDecimal(serviceRow["ServiceTotal"]);

                                ListViewItem item = new ListViewItem(serviceName);
                                item.SubItems.Add(servicePrice.ToString());
                                item.SubItems.Add(serviceQuantity.ToString());
                                item.SubItems.Add(serviceTotal.ToString());

                                listviewReceipt.Items.Add(item);
                            }
                            #endregion

                            // Add damaged item info
                            #region Calculate damaged fee iff service null
                            head = "- Compensation Fee:";
                            ListViewItem damfee = new ListViewItem(head);
                            listviewReceipt.Items.Add(damfee);

                            foreach (DataRow damagedRow in table.Rows)
                            {
                                string damName = damagedRow["DamagedItem"].ToString();
                                decimal damPrice = Convert.ToDecimal(damagedRow["DamagedPrice"]);
                                int damQuantity = Convert.ToInt32(damagedRow["DamagedAmount"]);
                                decimal damTotal = Convert.ToDecimal(damagedRow["DamagedTotal"]);

                                ListViewItem item = new ListViewItem(damName);
                                item.SubItems.Add(damPrice.ToString());
                                item.SubItems.Add(damQuantity.ToString());
                                item.SubItems.Add(damTotal.ToString());

                                listviewReceipt.Items.Add(item);
                            }
                            #endregion
                        }
                        else
                        {
                            // Add service detail info
                            #region Calculate service fee iff damaged null

                            head = "- Service Fee:";
                            ListViewItem serfee = new ListViewItem(head);
                            listviewReceipt.Items.Add(serfee);

                            foreach (DataRow serviceRow in table.Rows)
                            {
                                string serviceName = serviceRow["ServiceName"].ToString();
                                decimal servicePrice = Convert.ToDecimal(serviceRow["ServicePrice"]);
                                int serviceQuantity = Convert.ToInt32(serviceRow["NumberofUsers"]);
                                decimal serviceTotal = Convert.ToDecimal(serviceRow["ServiceTotal"]);

                                ListViewItem item = new ListViewItem(serviceName);
                                item.SubItems.Add(servicePrice.ToString());
                                item.SubItems.Add(serviceQuantity.ToString());
                                item.SubItems.Add(serviceTotal.ToString());

                                listviewReceipt.Items.Add(item);
                            }
                            #endregion
                        }
                    }
                    else if (Convert.ToString(row["DamagedItem"]) != "")
                    {
                        // Add damaged item info
                        #region Calculate damaged fee iff service null

                        head = "- Compensation Fee:";
                        ListViewItem damfee = new ListViewItem(head);
                        listviewReceipt.Items.Add(damfee);

                        foreach (DataRow damagedRow in table.Rows)
                        {
                            string damName = damagedRow["DamagedItem"].ToString();
                            decimal damPrice = Convert.ToDecimal(damagedRow["DamagedPrice"]);
                            int damQuantity = Convert.ToInt32(damagedRow["DamagedAmount"]);
                            decimal damTotal = Convert.ToDecimal(damagedRow["DamagedTotal"]);

                            ListViewItem item = new ListViewItem(damName);
                            item.SubItems.Add(damPrice.ToString());
                            item.SubItems.Add(damQuantity.ToString());
                            item.SubItems.Add(damTotal.ToString());

                            listviewReceipt.Items.Add(item);
                        }
                        #endregion
                    }
                }
            }
        }
    }
}