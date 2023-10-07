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
    public partial class Room : Form
    {
        bool Them;
        string err;
        BLRoom dbRO = new BLRoom();
        bool bsearch = false;
        public Room()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                if (bsearch)
                {
                    DataSet dataSet = dbRO.FindRoom(textRoom_no.Text);
                    DataTable dataTable = dataSet.Tables[0];
                    dgvROOM.DataSource = dataTable;
                    bsearch = false;
                }
                else
                {
                    DataSet dataSet = dbRO.TakeRoom();
                    DataTable dataTable = dataSet.Tables[0];
                    dgvROOM.DataSource = dataTable;

                    // Set the DataSource of the DataGridView

                    // Thay đổi độ rộng cột
                    dgvROOM.AutoResizeColumns();
                }
                // Xóa trống các đối tượng trong Panel
                this.txtroomID.ResetText();
                this.txtroom_No.ResetText();
                this.txtType.ResetText();
                this.txtCapacity.ResetText();
                this.txtPrice.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvROOM_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Employee does not have permisson to access this Form!!!");
            }
        }
        private void FormRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtroomID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            int newRoomID = Convert.ToInt32(dgvROOM.Rows[dgvROOM.Rows.Count - 2].Cells[0].Value) + 1;

            this.txtroomID.Text = newRoomID.ToString();
            this.txtroom_No.ResetText();
            this.txtType.ResetText();
            this.txtCapacity.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtroomID
            this.txtroom_No.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvROOM_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtroomID
            this.txtroomID.Enabled = false;
            this.txtroom_No.Focus();

        }
        private void dgvROOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvROOM.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtroomID.Text =
            dgvROOM.Rows[r].Cells[0].Value.ToString();
            this.txtroom_No.Text =
            dgvROOM.Rows[r].Cells[1].Value.ToString();
            this.txtType.Text =
            dgvROOM.Rows[r].Cells[2].Value.ToString();
            this.txtCapacity.Text =
            dgvROOM.Rows[r].Cells[3].Value.ToString();
            this.txtPrice.Text =
            dgvROOM.Rows[r].Cells[4].Value.ToString();
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
            this.txtroomID.ResetText();
            this.txtroom_No.ResetText();
            this.txtType.ResetText();
            this.txtCapacity.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvROOM_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                // Thực hiện lệnh
                BLRoom blRo = new BLRoom();
                if (blRo.AddRoom(Convert.ToInt32(this.txtroomID.Text), this.txtroom_No.Text, this.txtType.Text, Convert.ToInt32(this.txtCapacity.Text), Convert.ToDouble(this.txtPrice.Text), ref err))
                    MessageBox.Show("Add successfully!");
                LoadData();

            }
            else
            {
                // Thực hiện lệnh
                BLRoom blRo = new BLRoom();
                blRo.UpdateRoom(Convert.ToInt32(this.txtroomID.Text), this.txtroom_No.Text, this.txtType.Text, Convert.ToInt32(this.txtCapacity.Text), Convert.ToDouble(this.txtPrice.Text), ref err);
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
                int r = dgvROOM.CurrentCell.RowIndex;
                string strRO =
                dgvROOM.Rows[r].Cells[0].Value.ToString();
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
                    dbRO.DeleteRoom(ref err, Convert.ToInt32(strRO));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.bsearch = true;
            LoadData();
        }
    }
}
