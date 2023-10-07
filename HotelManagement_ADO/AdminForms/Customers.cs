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
    public partial class Customers : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLCustomer dbCus = new BLCustomer();
        public Customers()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                DataSet dataSet = dbCus.TakeCustomers();
                DataTable dataTable = dataSet.Tables[0];
                dgvCUSTOMERS.DataSource = dataTable;
                // Xóa trống các đối tượng trong Panel
                this.txtCID.ResetText();
                this.txtFullName.ResetText();
                this.dtpBirthday.ResetText();
                this.cbGender.ResetText();
                this.txtPhoneNo.ResetText();
                this.txtAdd.ResetText();
                this.txtIdentifyNumber.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvCUSTOMERS_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table CUSTOMER. Lỗi rồi!!!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtCID.Enabled = false;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            int newCID = Convert.ToInt32(dgvCUSTOMERS.Rows[dgvCUSTOMERS.Rows.Count - 2].Cells[0].Value) + 1;

            this.txtCID.Text = newCID.ToString();
            this.txtFullName.ResetText();
            this.dtpBirthday.ResetText();
            this.cbGender.ResetText();
            this.txtPhoneNo.ResetText();
            this.txtAdd.ResetText();
            this.txtIdentifyNumber.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtCID
            this.txtCID.Focus();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
   
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtbook_ID
            this.txtCID.Enabled = false;
            this.txtIdentifyNumber.Focus();

            dgvCUSTOMERS_CellClick(null, null);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvCUSTOMERS.CurrentCell.RowIndex;
                string strBD1 = dgvCUSTOMERS.Rows[r].Cells[0].Value.ToString();
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
                    dbCus.DeleteCustomers(ref err, Convert.ToInt32(strBD1));
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
            this.txtCID.ResetText();
            this.txtFullName.ResetText();
            this.dtpBirthday.ResetText();
            this.cbGender.ResetText();
            this.txtPhoneNo.ResetText();
            this.txtAdd.ResetText();
            this.txtIdentifyNumber.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvCUSTOMERS_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                BLCustomer bcus = new BLCustomer();
                bool gen = false;
                if (cbGender.Text == "Male")
                    gen = true;
                if (bcus.AddCustomers(
                    this.txtFullName.Text,
                    this.dtpBirthday.Value,
                    gen,
                    this.txtPhoneNo.Text,
                    this.txtAdd.Text,
                    this.txtIdentifyNumber.Text, ref err))
                    MessageBox.Show("Add successfully");
                LoadData();
            }
            else
            {
                // Thực hiện lệnh
                BLCustomer bcus = new BLCustomer();
                bool gen = false;
                if (cbGender.Text == "Male")
                    gen = true;
                if (bcus.UpdateCustomers(
                    Convert.ToInt32(this.txtCID.Text),
                    this.txtFullName.Text,
                    DateTime.Parse(this.dtpBirthday.Text),
                    gen,                  
                    this.txtPhoneNo.Text,
                    this.txtAdd.Text,
                    this.txtIdentifyNumber.Text, ref err))
                LoadData();
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void dgvCUSTOMERS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvCUSTOMERS.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtCID.Text = dgvCUSTOMERS.Rows[r].Cells[0].Value.ToString();
            this.txtFullName.Text = dgvCUSTOMERS.Rows[r].Cells[1].Value.ToString();
            this.dtpBirthday.Text = dgvCUSTOMERS.Rows[r].Cells[2].Value.ToString();
            this.cbGender.Text = dgvCUSTOMERS.Rows[r].Cells[3].Value.ToString();
            this.txtPhoneNo.Text = dgvCUSTOMERS.Rows[r].Cells[4].Value.ToString();
            this.txtAdd.Text = dgvCUSTOMERS.Rows[r].Cells[5].Value.ToString();
            this.txtIdentifyNumber.Text = dgvCUSTOMERS.Rows[r].Cells[6].Value.ToString();
        }
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
