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

namespace HotelManagement_ADO.AdminForms
{
    public partial class BookingDetail : Form
    {
        bool Them;
        string err;
        BLBookingDetail dbBD = new BLBookingDetail();
        public BookingDetail()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                DataSet dataSet = dbBD.TakeBookingDetail();
                DataTable dataTable = dataSet.Tables[0];
                dgvBOOKINGDETAIL.DataSource = dataTable;
                // Change the column name
                // Set the DataSource of the DataGridView
                dgvBOOKINGDETAIL.DataSource = dataTable;
                // Xóa trống các đối tượng trong Panel
                this.txtbook_ID.ResetText();
                this.txtroom_ID.ResetText();
                this.txtPrice.ResetText();
                this.txtUnit.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvBOOKINGDETAIL_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table BOOKINGDETAIL. Lỗi rồi!!!");
            }
        }
        private void FormBookingDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtbook_ID.Enabled = true;
            this.txtroom_ID.Enabled = true;
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtbook_ID.ResetText();
            this.txtroom_ID.ResetText();
            this.txtPrice.ResetText();
            this.txtUnit.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtbook_ID.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvBOOKINGDETAIL_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtbook_ID.Enabled = false;
            this.txtroom_ID.Enabled = false;
            this.txtPrice.Focus();

        }
        private void dgvBOOKINGDETAIL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvBOOKINGDETAIL.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtbook_ID.Text =
            dgvBOOKINGDETAIL.Rows[r].Cells[0].Value.ToString();
            this.txtroom_ID.Text =
            dgvBOOKINGDETAIL.Rows[r].Cells[1].Value.ToString();
            this.txtPrice.Text =
            dgvBOOKINGDETAIL.Rows[r].Cells[2].Value.ToString();
            this.txtUnit.Text =
            dgvBOOKINGDETAIL.Rows[r].Cells[3].Value.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtbook_ID.ResetText();
            this.txtroom_ID.ResetText();
            this.txtPrice.ResetText();
            this.txtUnit.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvBOOKINGDETAIL_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                BLBookingDetail blBd = new BLBookingDetail();
                if (blBd.AddBookingDetail(Convert.ToInt32(this.txtbook_ID.Text), Convert.ToInt32(this.txtroom_ID.Text), Convert.ToDouble(this.txtPrice.Text), Convert.ToInt32(this.txtUnit.Text), ref err))
                    MessageBox.Show("Add successfully");
                LoadData();
            }
            else
            {
                // Thực hiện lệnh
                BLBookingDetail blBd = new BLBookingDetail();
                blBd.UpdateBookingDetail(Convert.ToInt32(this.txtbook_ID.Text), Convert.ToInt32(this.txtroom_ID.Text), Convert.ToDouble(this.txtPrice.Text), Convert.ToInt32(this.txtUnit.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvBOOKINGDETAIL.CurrentCell.RowIndex;
                string strBD1 =
                dgvBOOKINGDETAIL.Rows[r].Cells[0].Value.ToString();
                string strBD2 =
                dgvBOOKINGDETAIL.Rows[r].Cells[1].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbBD.DeleteBookingDetail(ref err, Convert.ToInt32(strBD1), Convert.ToInt32(strBD2));
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
    }
}
