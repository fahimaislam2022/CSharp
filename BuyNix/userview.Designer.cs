namespace SuperMArketManagementSystem_BuyNix_
{
    partial class userview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userview));
            panel1 = new Panel();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 61, 204);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 748);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(95, 61, 204);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 748);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(289, 383);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(445, 28);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "-Select-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(75, 383);
            label6.Name = "label6";
            label6.Size = new Size(132, 39);
            label6.TabIndex = 25;
            label6.Text = "Gender:";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(75, 316);
            label8.Name = "label8";
            label8.Size = new Size(168, 39);
            label8.TabIndex = 24;
            label8.Text = "Birth date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(289, 325);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(445, 27);
            dateTimePicker2.TabIndex = 23;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(771, 116);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(178, 55);
            button4.TabIndex = 20;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(632, 451);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(178, 55);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(401, 451);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(178, 55);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(181, 451);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(178, 55);
            button1.TabIndex = 15;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(181, 532);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(630, 200);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            textBox3.Location = new Point(289, 255);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(445, 44);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(0, 255);
            label4.Name = "label4";
            label4.Size = new Size(299, 39);
            label4.TabIndex = 8;
            label4.Text = "Confirm Password :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            textBox2.Location = new Point(289, 184);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 44);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(289, 116);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 44);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(75, 184);
            label3.Name = "label3";
            label3.Size = new Size(180, 39);
            label3.TabIndex = 5;
            label3.Text = "Password : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(75, 116);
            label2.Name = "label2";
            label2.Size = new Size(205, 39);
            label2.TabIndex = 4;
            label2.Text = "User Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(376, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 51);
            label1.TabIndex = 3;
            label1.Text = "User Details";
            // 
            // userview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "userview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userview";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox4;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Label label6;
    }
}