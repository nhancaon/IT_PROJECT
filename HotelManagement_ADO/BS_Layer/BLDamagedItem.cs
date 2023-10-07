using HotelManagement_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_ADO.BS_Layer
{
    public class BLDamagedItem
    {
        DBMain db = null;
        public BLDamagedItem()
        {
            db = new DBMain();
        }
        public DataSet TakeDamagedItem()
        {
            return db.ExecuteQueryDataSet("Select * from View_DamagedItem", CommandType.Text);
        }
        public bool AddDamagedItem(int itemID, int book_ID, int DamagedAmount, double DamagedPrice, ref string err)
        {
            try
            {
                string sql = $"exec SP_ADD_DAMAGED_ITEM {itemID},{book_ID}, {DamagedAmount},{DamagedPrice}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteDamagedItem(ref string err, int itemID,int book_ID)
        {
            try
            {
                string sql = $"exec SP_DELETE_DAMAGED_ITEM {itemID},{book_ID }";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateDamagedItem(int itemID, int book_ID, int DamagedAmount, double DamagedPrice,ref string err)
        {
            try
            {
                string sql = $"exec SP_UPDATE_DAMAGED_ITEM {itemID},{book_ID}, {DamagedAmount},{DamagedPrice}";
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
