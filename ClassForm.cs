using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHungPhat68PM3
{
    public partial class ClassForm : Form
    {
        string connectionString = @"Data Source=PHSAMAST;Initial Catalog=StudentManagement;Integrated Security=True";

        public ClassForm()
        {
            InitializeComponent();

            // Danh sách ca học
            cbShift.Items.Add("Ca 1 (7h - 9h)");
            cbShift.Items.Add("Ca 2 (9h - 11h)");
            cbShift.Items.Add("Ca 3 (13h - 15h)");
            cbShift.Items.Add("Ca 4 (15h - 17h)");
        }

        // Load danh sách lớp
        void LoadClasses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Classes";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvClasses.DataSource = dt;
            }
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        // Thêm lớp
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Classes(ClassName, Department, Shift)
                                 VALUES(@name,@dept,@shift)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtClassName.Text);
                cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@shift", cbShift.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm lớp thành công");
            LoadClasses();
        }

        // Sửa lớp
        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp");
                return;
            }

            int id = Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Classes 
                                 SET ClassName=@name,
                                     Department=@dept,
                                     Shift=@shift
                                 WHERE ClassId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", txtClassName.Text);
                cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@shift", cbShift.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật thành công");
            LoadClasses();
        }

        // Xóa lớp
        private void button11_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa");
                return;
            }

            int id = Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassId"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Classes WHERE ClassId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa lớp thành công");
            LoadClasses();
        }

        // Load lại danh sách
        private void btnLoadClass_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }

        // Click DataGridView -> hiển thị lên textbox
        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClasses.CurrentRow == null) return;

            txtClassName.Text = dgvClasses.CurrentRow.Cells["ClassName"].Value.ToString();
            txtDepartment.Text = dgvClasses.CurrentRow.Cells["Department"].Value.ToString();
            cbShift.Text = dgvClasses.CurrentRow.Cells["Shift"].Value.ToString();
        }
    }
}