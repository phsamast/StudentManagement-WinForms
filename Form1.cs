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

            comboBox3.Items.Add("Male");
            comboBox3.Items.Add("Female");
        }

        void LoadStudents()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView3.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ADD
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button chạy");
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "INSERT INTO Students(Name,Age,Gender,Major) VALUES(@Name,@Age,@Gender,@Major)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", textBox7.Text);
            cmd.Parameters.AddWithValue("@Age", textBox8.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Major", textBox9.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadStudents();
        }

        // UPDATE
        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!");
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "UPDATE Students SET Name=@Name, Age=@Age, Gender=@Gender, Major=@Major WHERE StudentId=@Id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", dataGridView3.CurrentRow.Cells["StudentId"].Value);
            cmd.Parameters.AddWithValue("@Name", textBox7.Text);
            cmd.Parameters.AddWithValue("@Age", textBox8.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Major", textBox9.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadStudents();
        }

        // DELETE
        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "DELETE FROM Students WHERE StudentId=@Id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", dataGridView3.CurrentRow.Cells["StudentId"].Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadStudents();
        }
        // LOAD
        private void button12_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // CLICK DATA
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView3.CurrentRow.Cells["Name"].Value.ToString();
            textBox8.Text = dataGridView3.CurrentRow.Cells["Age"].Value.ToString();
            comboBox3.Text = dataGridView3.CurrentRow.Cells["Gender"].Value.ToString();
            textBox9.Text = dataGridView3.CurrentRow.Cells["Major"].Value.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}