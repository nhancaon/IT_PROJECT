using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HotelManagement_ADO.DB_Layer;

namespace HotelManagement_ADO.BS_Layer
{
    public class BLCustomerDetail
    {
        DBMain db = null;
        public BLCustomerDetail()
        {
            db = new DBMain();
        }
        public DataSet TakeCustomerDetail()
        {
            return db.ExecuteQueryDataSet("Select * from View_CustomerDetail", CommandType.Text);
        }
        public bool AddCustomerDetail(int book_ID, int room_ID, int customerID, ref string err)
        {
            try
            {
                string sql = $"exec SP_ADD_CUSTOMER_DETAIL {book_ID}, {room_ID}, {customerID}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteCustomerDetail(ref string err, int book_ID, int room_ID, int customerID)
        {
            try
            {
                string sql = $"exec SP_DELETE_CUSTOMER_DETAIL {book_ID}, {room_ID}, {customerID}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
    }
}
