using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHungPhat68PM3
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=PHSAMAST;Initial Catalog=StudentManagement;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            comboBox4.Items.Add("Male");
            comboBox4.Items.Add("Female");
        }

        // LOAD DATA
        void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView4.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ADD
        private void button13_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students(Name,Age,Gender,Major) VALUES(@Name,@Age,@Gender,@Major)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", textBox10.Text);
                cmd.Parameters.AddWithValue("@Age", textBox11.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox4.Text);
                cmd.Parameters.AddWithValue("@Major", textBox12.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm sinh viên thành công");

            LoadStudents();
        }

        // UPDATE
        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa");
                return;
            }

            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Students SET Name=@Name, Age=@Age, Gender=@Gender, Major=@Major WHERE StudentId=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", textBox10.Text);
                cmd.Parameters.AddWithValue("@Age", textBox11.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox4.Text);
                cmd.Parameters.AddWithValue("@Major", textBox12.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật thành công");

            LoadStudents();
        }

        // DELETE
        private void button15_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa");
                return;
            }

            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Students WHERE StudentId=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa thành công");

            LoadStudents();
        }

        // LOAD BUTTON
        private void button16_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            ClassForm f = new ClassForm();
            f.Show();
        }

        // CLICK DATA GRID
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.CurrentRow == null) return;

            textBox10.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            comboBox4.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            textBox12.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}