﻿namespace SuperMArketManagementSystem_BuyNix_
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 753);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(653, 605);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(191, 56);
            button1.TabIndex = 12;
            button1.Text = "Register Now!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(789, 539);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "-Select-";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(792, 489);
            label6.Name = "label6";
            label6.Size = new Size(132, 39);
            label6.TabIndex = 10;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(520, 489);
            label5.Name = "label5";
            label5.Size = new Size(159, 39);
            label5.TabIndex = 9;
            label5.Text = "Birthdate:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(520, 535);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(520, 405);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(476, 49);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(520, 360);
            label4.Name = "label4";
            label4.Size = new Size(290, 39);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password:";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(520, 288);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(476, 49);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(520, 227);
            label3.Name = "label3";
            label3.Size = new Size(162, 39);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(520, 152);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 49);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(520, 93);
            label2.Name = "label2";
            label2.Size = new Size(187, 39);
            label2.TabIndex = 2;
            label2.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(653, 31);
            label1.Name = "label1";
            label1.Size = new Size(205, 39);
            label1.TabIndex = 1;
            label1.Text = "Register Now";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(95, 61, 204);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 753);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 87);
            label7.Name = "label7";
            label7.Size = new Size(326, 45);
            label7.TabIndex = 1;
            label7.Text = "Create an account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 185);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private PictureBox pictureBox3;
    }
}