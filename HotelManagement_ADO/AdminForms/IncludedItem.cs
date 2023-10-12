using HotelManagement_ADO.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_ADO.AdminForms
{
    public partial class IncludedItem : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;

        BLIncludedItem dbIncludedItem = new BLIncludedItem();
        public IncludedItem()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                DataSet dataSet = dbIncludedItem.TakeIncludedItem();
                DataTable dataTable = dataSet.Tables[0];

                dgvINCLUDEDITEM.DataSource = dataTable;
                // Xóa trống các đối tượng trong Panel
                this.txtitemID.ResetText();
                this.txtitemName.ResetText();
                this.txtroomType.ResetText();
                this.txtiiPrice.ResetText();
                this.txtiiAmount.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvINCLUDEDITEM_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table INCLUDEDITEM. Lỗi rồi!!!");
            }
        }

        private void IncludedItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtitemID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            int newIncludedItem = Convert.ToInt32(dgvINCLUDEDITEM.Rows[dgvINCLUDEDITEM.Rows.Count - 2].Cells[0].Value) + 1;

            this.txtitemID.Text = newIncludedItem.ToString();
            this.txtitemName.ResetText();
            this.txtroomType.ResetText();
            this.txtiiPrice.ResetText();
            this.txtiiAmount.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtitemID
            this.txtitemName.Focus();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvINCLUDEDITEM_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtitemID.Enabled = false;
            this.txtitemName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvINCLUDEDITEM.CurrentCell.RowIndex;
                string strII1 = dgvINCLUDEDITEM.Rows[r].Cells[0].Value.ToString();
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
                    dbIncludedItem.DeleteIncludedItem(ref err, Convert.ToInt32(strII1));
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
            this.txtroomType.ResetText();
            this.txtiiPrice.ResetText();
            this.txtiiAmount.ResetText();
            // Allow manipulation in button Add / Fix / Delete / Back
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Ban manipulation in button Save / Cancel / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvINCLUDEDITEM_CellClick(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                BLIncludedItem ii = new BLIncludedItem();
                if (ii.AddIncludedItem( this.txtitemName.Text, 
                                        this.txtroomType.Text, 
                                        Convert.ToDouble(this.txtiiPrice.Text),
                                        Convert.ToInt32(this.txtiiAmount.Text), ref err))
                MessageBox.Show("Add successfully");
                LoadData();
            }
            else
            {
                // Thực hiện lệnh
                BLIncludedItem ii = new BLIncludedItem();
                ii.UpdateIncludedItem( Convert.ToInt32(this.txtitemID.Text), 
                                       this.txtitemName.Text,
                                       this.txtroomType.Text,
                                       Convert.ToDouble(this.txtiiPrice.Text), 
                                       Convert.ToInt32(this.txtiiAmount.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void dgvINCLUDEDITEM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvINCLUDEDITEM.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtitemID.Text = dgvINCLUDEDITEM.Rows[r].Cells[0].Value.ToString();
            this.txtitemName.Text = dgvINCLUDEDITEM.Rows[r].Cells[1].Value.ToString();
            this.txtroomType.Text = dgvINCLUDEDITEM.Rows[r].Cells[2].Value.ToString();
            this.txtiiPrice.Text = dgvINCLUDEDITEM.Rows[r].Cells[3].Value.ToString();
            this.txtiiAmount.Text = dgvINCLUDEDITEM.Rows[r].Cells[4].Value.ToString();
        }
    }
}
