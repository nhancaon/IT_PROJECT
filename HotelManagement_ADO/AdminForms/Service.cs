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
    public partial class Service : Form
    {
        bool Them;
        string err;
        BLService dbSE = new BLService();
        public Service()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView

                DataSet dataSet = dbSE.TakeService();
                DataTable dataTable = dataSet.Tables[0];
                dgvService.DataSource = dataTable;


                // Set the DataSource of the DataGridView
                dgvService.DataSource = dataTable;

                // Thay đổi độ rộng cột
                dgvService.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtSerID.ResetText();
                this.txtBookID.ResetText();
                this.txtCusID.ResetText();
                this.txtProID.ResetText();
                this.txtPrice.ResetText();
                this.txtAmount.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.pnService.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvService_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table SERVICE. Lỗi rồi!!!");
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtSerID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            int newSerID = Convert.ToInt32(dgvService.Rows[dgvService.Rows.Count - 2].Cells[0].Value) + 1;

            this.txtSerID.Text = newSerID.ToString();
            this.txtBookID.ResetText();
            this.txtCusID.ResetText();
            this.txtProID.ResetText();
            this.txtPrice.ResetText();
            this.txtAmount.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.pnService.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtroomID
            this.txtBookID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                BLService dbSE = new BLService();
                if (dbSE.AddService(Convert.ToInt32(this.txtBookID.Text), Convert.ToInt32(this.txtCusID.Text), Convert.ToInt32(this.txtProID.Text), 1, Convert.ToInt32(this.txtAmount.Text), dtpPaydate.Value, ref err) == true) MessageBox.Show("Add successfully!"); ;

                LoadData();
            }
            else
            {
                // Thực hiện lệnh
                BLService dbSE = new BLService(); ;
                dbSE.UpdateService(Convert.ToInt32(this.txtSerID.Text), Convert.ToInt32(this.txtBookID.Text), Convert.ToInt32(this.txtCusID.Text), Convert.ToInt32(this.txtProID.Text), 1, Convert.ToInt32(this.txtAmount.Text), dtpPaydate.Value, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtSerID.ResetText();
            this.txtBookID.ResetText();
            this.txtCusID.ResetText();
            this.txtProID.ResetText();
            this.txtPrice.ResetText();
            this.txtAmount.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.pnService.Enabled = false;
            dgvService_CellClick(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnService.Enabled = true;
            dgvService_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.pnService.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtroomID
            this.txtSerID.Enabled = false;
            this.txtBookID.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void FormService_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvService.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtSerID.Text =
            dgvService.Rows[r].Cells[0].Value.ToString();
            this.txtBookID.Text =
            dgvService.Rows[r].Cells[1].Value.ToString();
            this.txtCusID.Text =
            dgvService.Rows[r].Cells[2].Value.ToString();
            this.txtProID.Text =
            dgvService.Rows[r].Cells[3].Value.ToString();
            this.txtPrice.Text =
            dgvService.Rows[r].Cells[4].Value.ToString();
            this.txtAmount.Text =
            dgvService.Rows[r].Cells[5].Value.ToString();
            this.dtpPaydate.Text =
            dgvService.Rows[r].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvService.CurrentCell.RowIndex;
                string strRO =
                dgvService.Rows[r].Cells[0].Value.ToString();
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
                    dbSE.DeleteService(ref err, Convert.ToInt32(strRO));
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
