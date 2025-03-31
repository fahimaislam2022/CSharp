namespace SuperMArketManagementSystem_BuyNix_
{
    partial class ViewofUser
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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 561);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(469, 436);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(472, 399);
            label6.Name = "label6";
            label6.Size = new Size(107, 31);
            label6.TabIndex = 20;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(234, 399);
            label5.Name = "label5";
            label5.Size = new Size(138, 31);
            label5.TabIndex = 19;
            label5.Text = "Birth date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(234, 433);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(234, 336);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(417, 38);
            textBox3.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(234, 302);
            label4.Name = "label4";
            label4.Size = new Size(236, 31);
            label4.TabIndex = 16;
            label4.Text = "Confrim Password:";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(234, 248);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(417, 38);
            textBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(234, 202);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(234, 146);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 38);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(234, 102);
            label2.Name = "label2";
            label2.Size = new Size(151, 31);
            label2.TabIndex = 12;
            label2.Text = "User Name:";
            // 
            // ViewofUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Name = "ViewofUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewofUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
    }
}