using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using HotelManagement_ADO.DB_Layer;

namespace HotelManagement_ADO.BS_Layer
{
    public class BLProduct
    {
        DBMain db = null;
        public BLProduct()
        {
            db = new DBMain();
        }
        public DataSet TakeProduct()
        {
            return db.ExecuteQueryDataSet("Select * from View_Product", CommandType.Text);
        }
        public bool AddProduct(int pID, int cate_ID, string Title, string Thumbnail, string Decription, double Price, int Amount, ref string err)
        {
            try
            {
                string sql = $"exec SP_ADD_PRODUCT {cate_ID}, '{Title}', '{Thumbnail}', '{Decription}', {Price}, {Amount}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteProduct(ref string err, int pID)
        {
            try
            {
                string sql = $"exec SP_DELETE_PRODUCT {pID}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateProduct(int pID, int cate_ID, string Title, string Thumbnail, string Decription, double Price, int Amount, ref string err)
        {
            try
            {
                string sql = $"exec SP_UPDATE_PRODUCT {pID}, {cate_ID}, '{Title}', '{Thumbnail}', '{Decription}', {Price}, {Amount}";
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
