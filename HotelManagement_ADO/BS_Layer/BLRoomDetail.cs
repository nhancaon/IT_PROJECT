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
    class BLRoomDetail
    {
        DBMain db = null;
        public BLRoomDetail()
        {
            db = new DBMain();
        }
        public DataSet TakeRoomDetail()
        {
            return db.ExecuteQueryDataSet("Select * from View_RoomDetail", CommandType.Text);
        }
        public bool AddRoomDetail(int room_ID,double LenghthofStay, double Price,ref string err)
        {
            try
            {
                string sql = $"exec SP_ADD_ROOM_DETAIL {room_ID}, {LenghthofStay}, {Price}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteRoomDetail(ref string err, int book_ID, int room_ID)
        {
            try
            {
                string sql = $"exec SP_DELETE_ROOM_DETAIL {book_ID}, {room_ID}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateRoomDetail(int book_ID, int room_ID, double LenghthofStay, double Price, ref string err)
        {
            try
            {
                string sql = $"exec SP_UPDATE_ROOM_DETAIL {book_ID}, {room_ID}, {LenghthofStay}, {Price}";
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
