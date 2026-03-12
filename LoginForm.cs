using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHungPhat68PM3
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=PHSAMAST;Initial Catalog=StudentManagement;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();

            // Ẩn ký tự password
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "SELECT COUNT(*) FROM Users WHERE Username=@user AND Password=@pass";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            conn.Open();

            int result = (int)cmd.ExecuteScalar();

            conn.Close();

            if (result > 0)
            {
                MessageBox.Show("Đăng nhập thành công");

                Form1 qlsv = new Form1();
                qlsv.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(431, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(986, 666);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}