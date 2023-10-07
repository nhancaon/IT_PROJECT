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
    public partial class Users : Form
    {
        bool Them;
        string err;
        BLUsers dbU = new BLUsers();
        bool bsearch = false;
        public Users()
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
                    DataSet dataSet = dbU.FindUser(Convert.ToInt32(textID.Text), textName.Text);
                    DataTable dataTable = dataSet.Tables[0];
                    dgvUSER.DataSource = dataTable;
                    bsearch = false;
                }
                else
                {
                    DataSet dataSet = dbU.TakeUser();
                    DataTable dataTable = dataSet.Tables[0];

                    dgvUSER.DataSource = dataTable;
                    dgvUSER.AutoResizeColumns();

                }
                //// Thay đổi độ rộng cột
                //dgvUSER.AutoResizeColumns();

                // Xóa trống các đối tượng trong Panel
                this.txtuserID.ResetText();
                this.txtFullname.ResetText();
                this.txtPassword.ResetText();
                this.dtpBirthday.ResetText();
                this.cbGender.ResetText();
                this.txtEmail.ResetText();
                this.txtPhone_Number.ResetText();
                this.txtAddress.ResetText();
                this.txtrole_id.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvUSER_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Employee does not have permisson to access this Form!!!");
            }
        }
        private void FromUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtuserID.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            int newUserId = Convert.ToInt32(dgvUSER.Rows[dgvUSER.Rows.Count - 2].Cells[0].Value) + 1;

            this.txtuserID.Text = newUserId.ToString();

            this.txtFullname.ResetText();
            this.txtPassword.ResetText();
            this.dtpBirthday.ResetText();
            this.cbGender.ResetText();
            this.txtEmail.ResetText();
            this.txtPhone_Number.ResetText();
            this.txtAddress.ResetText();
            this.txtrole_id.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtUserID
            this.txtFullname.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvUSER_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtUserID
            this.txtuserID.Enabled = false;
            this.txtFullname.Focus();

        }
        private void dgvUSER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvUSER.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtuserID.Text =
            dgvUSER.Rows[r].Cells[0].Value.ToString();
            this.txtFullname.Text =
            dgvUSER.Rows[r].Cells[1].Value.ToString();
            this.dtpBirthday.Text =
            dgvUSER.Rows[r].Cells[2].Value.ToString();
            this.cbGender.Text =
            dgvUSER.Rows[r].Cells[3].Value.ToString();
            this.txtEmail.Text =
            dgvUSER.Rows[r].Cells[4].Value.ToString();
            this.txtPhone_Number.Text =
            dgvUSER.Rows[r].Cells[5].Value.ToString();
            this.txtAddress.Text =
            dgvUSER.Rows[r].Cells[6].Value.ToString();
            this.txtrole_id.Text =
            dgvUSER.Rows[r].Cells[7].Value.ToString();
            this.txtPassword.Text =
            dgvUSER.Rows[r].Cells[8].Value.ToString();
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
            this.txtuserID.ResetText();
            this.txtFullname.ResetText();
            this.txtPassword.ResetText();
            this.dtpBirthday.ResetText();
            this.cbGender.ResetText();
            this.txtEmail.ResetText();
            this.txtPhone_Number.ResetText();
            this.txtAddress.ResetText();
            this.txtrole_id.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvUSER_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            Console.WriteLine(cbGender.Text);
            if (Them)
            {
                bool gen = false;
                if (cbGender.Text == "Male")
                    gen = true;
                BLUsers blU = new BLUsers();
                if (blU.AddUser(Convert.ToInt32(this.txtuserID.Text), this.txtFullname.Text, this.txtPassword.Text, this.dtpBirthday.Value, gen, this.txtEmail.Text, this.txtPhone_Number.Text, this.txtAddress.Text, Convert.ToInt32(this.txtrole_id.Text), ref err))
                    MessageBox.Show("Add successfully!");
                LoadData();
            }
            else
            {
                bool gen = false;
                if (cbGender.Text == "Male")
                    gen = true;
                // Thực hiện lệnh
                BLUsers blU = new BLUsers();
                blU.UpdateUser(Convert.ToInt32(this.txtuserID.Text), this.txtFullname.Text, this.txtPassword.Text, this.dtpBirthday.Value, gen, this.txtEmail.Text, this.txtPhone_Number.Text, this.txtAddress.Text, Convert.ToInt32(this.txtrole_id.Text), ref err);
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
                int r = dgvUSER.CurrentCell.RowIndex;
                string strU =
                dgvUSER.Rows[r].Cells[0].Value.ToString();
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
                    dbU.DeleteUser(ref err, Convert.ToInt32(strU));
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
