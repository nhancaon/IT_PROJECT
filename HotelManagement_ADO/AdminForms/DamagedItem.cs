using HotelManagement_ADO.BS_Layer;
using HotelManagement_ADO.DB_Layer;
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
using System.Xml.Linq;

namespace HotelManagement_ADO.AdminForms
{
    public partial class DamagedItem : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;

        BLDamagedItem dbDamagedItem = new BLDamagedItem();
        public DamagedItem()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                DataSet dataSet = dbDamagedItem.TakeDamagedItem();
                DataTable dataTable = dataSet.Tables[0];

                dgvDAMAGEDITEM.DataSource = dataTable;
                // Xóa trống các đối tượng trong Panel
                this.txtitemID.ResetText();
                this.txtitemName.ResetText();
                this.txtbookID.ResetText();
                this.txtdiAmount.ResetText();
                this.txtdiPrice.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvDAMAGEDITEM_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table DAMAGEDITEM. Lỗi rồi!!!");
            }
        }

        private void DamagedItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDAMAGEDITEM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvDAMAGEDITEM.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtbookID.Text = dgvDAMAGEDITEM.Rows[r].Cells[0].Value.ToString();
            this.txtitemID.Text = dgvDAMAGEDITEM.Rows[r].Cells[1].Value.ToString();
            this.txtitemName.Text = dgvDAMAGEDITEM.Rows[r].Cells[2].Value.ToString();
            this.txtdiAmount.Text = dgvDAMAGEDITEM.Rows[r].Cells[3].Value.ToString();
            this.txtdiPrice.Text = dgvDAMAGEDITEM.Rows[r].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Activate Them variable
            Them = true;
            // Delete all contents of each box in panel
            this.txtitemID.ResetText();
            this.txtitemName.ResetText();
            this.txtbookID.ResetText();
            this.txtdiAmount.ResetText();
            this.txtdiPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbookID
            this.txtbookID.Focus();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvDAMAGEDITEM_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbookID
            this.txtitemID.Enabled = false;
            this.txtbookID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvDAMAGEDITEM.CurrentCell.RowIndex;
                string strDI1 = dgvDAMAGEDITEM.Rows[r].Cells[1].Value.ToString();
                string strDI2 = dgvDAMAGEDITEM.Rows[r].Cells[0].Value.ToString();
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
                    dbDamagedItem.DeleteDamagedItem(ref err, Convert.ToInt32(strDI1), Convert.ToInt32(strDI2));
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Declare answering variable
            DialogResult ans;
            // Display Q&A box
            ans = MessageBox.Show("Are you sure?", "Answer",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Check if press OK button
            if (ans == DialogResult.OK) this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Delete all contents of each box in panel
            this.txtitemID.ResetText();
            this.txtitemName.ResetText();
            this.txtbookID.ResetText();
            this.txtdiAmount.ResetText();
            this.txtdiPrice.ResetText();
            // Allow manipulation in button Add / Fix / Delete / Back
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Ban manipulation in button Save / Cancel / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvDAMAGEDITEM_CellClick(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                BLDamagedItem di = new BLDamagedItem();
                if (di.AddDamagedItem( this.txtitemName.Text,
                                       Convert.ToInt32(this.txtbookID.Text),
                                       Convert.ToInt32(this.txtdiAmount.Text), ref err))
                MessageBox.Show("Add successfully");
                LoadData();
            }
            else
            {
                // Thực hiện lệnh
                BLDamagedItem di = new BLDamagedItem();
                di.UpdateDamagedItem( this.txtitemName.Text,
                                       Convert.ToInt32(this.txtbookID.Text),
                                       Convert.ToInt32(this.txtdiAmount.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
    }
}
