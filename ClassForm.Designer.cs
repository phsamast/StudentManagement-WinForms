namespace NguyenHungPhat68PM3
{
    partial class ClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnLoadClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(116, 119);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 22);
            this.txtClassName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn học:";
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddClass.Location = new System.Drawing.Point(35, 215);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(268, 32);
            this.btnAddClass.TabIndex = 2;
            this.btnAddClass.Text = "Thêm lớp";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // dgvClasses
            // 
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(359, 12);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.Size = new System.Drawing.Size(626, 662);
            this.dgvClasses.TabIndex = 4;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(116, 147);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 22);
            this.txtDepartment.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phòng học:";
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Location = new System.Drawing.Point(113, 175);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(121, 24);
            this.cbShift.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ca học:";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateClass.Location = new System.Drawing.Point(35, 253);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(268, 32);
            this.btnUpdateClass.TabIndex = 9;
            this.btnUpdateClass.Text = "Sửa lớp";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button11.Location = new System.Drawing.Point(35, 291);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(268, 32);
            this.button11.TabIndex = 10;
            this.button11.Text = "Xóa lớp";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnLoadClass
            // 
            this.btnLoadClass.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnLoadClass.Location = new System.Drawing.Point(35, 329);
            this.btnLoadClass.Name = "btnLoadClass";
            this.btnLoadClass.Size = new System.Drawing.Size(268, 32);
            this.btnLoadClass.TabIndex = 11;
            this.btnLoadClass.Text = "Load";
            this.btnLoadClass.UseVisualStyleBackColor = false;
            this.btnLoadClass.Click += new System.EventHandler(this.btnLoadClass_Click);
            // 
            // ClassForm
            // 
            this.ClientSize = new System.Drawing.Size(997, 686);
            this.Controls.Add(this.btnLoadClass);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassName);
            this.Name = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnLoadClass;
    }
}