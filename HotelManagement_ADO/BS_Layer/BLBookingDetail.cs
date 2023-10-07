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
    class BLBookingDetail
    {
        DBMain db = null;
        public BLBookingDetail()
        {
            db = new DBMain();
        }
        public DataSet TakeBookingDetail()
        {
            return db.ExecuteQueryDataSet("Select * from View_BookingDetail", CommandType.Text);
        }
        public bool AddBookingDetail(int book_ID, int room_ID, double Price, int Unit, ref string err)
        {
            try
            {
                string sql = $"exec SP_ADD_BOOKING_DETAIL {book_ID}, {room_ID}, {Price}, {Unit}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;

        }
        public bool DeleteBookingDetail(ref string err, int book_ID, int room_ID)
        {
            try
            {
                string sql = $"exec SP_DELETE_BOOKING_DETAIL {book_ID}, {room_ID}";
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
        public bool UpdateBookingDetail(int book_ID, int room_ID, double Price, int Unit, ref string err)
        {
            try
            {
                string sql = $"exec SP_UPDATE_BOOKING_DETAIL {book_ID}, {room_ID}, {Price}, {Unit}";
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
