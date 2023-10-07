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
    public class BLService
    {
        DBMain db = null;
        public BLService()
        {
            db = new DBMain();
        }
        public DataSet TakeService()
        {
            return db.ExecuteQueryDataSet("Select * from View_Service", CommandType.Text);
        }
        public bool AddService(int book_ID, int customerID, int product_ID, double Price, int Amount, DateTime Buy_Date, ref string err)
        {
            try
            {
                string sql = $"exec SP_ADD_SERVICE {book_ID}, {customerID}, {product_ID}, {Price}, {Amount}, '{Buy_Date.ToString()}'";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteService(ref string err, int serID)
        {
            try
            {   
                string sql = $"exec SP_DELETE_SERVICE '{serID}'";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateService(int serID, int book_ID, int customerID, int product_ID, double Price, int Amount, DateTime Buy_Date, ref string err)
        {
            try
            {
                string sql = $"exec SP_UPDATE_SERVICE {serID}, {book_ID}, {customerID}, {product_ID}, {Price}, {Amount}, '{Buy_Date.ToString()}'";
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
