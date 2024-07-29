namespace CSharp_BangCuuChuong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnTinh = new Button();
            lblKQ = new Label();
            txtChon = new TextBox();
            groupBox1 = new GroupBox();
            rdo9 = new RadioButton();
            rdo8 = new RadioButton();
            rdo7 = new RadioButton();
            rdo6 = new RadioButton();
            rdo5 = new RadioButton();
            rdo4 = new RadioButton();
            rdo3 = new RadioButton();
            rdo2 = new RadioButton();
            trackBar1 = new TrackBar();
            listBox1 = new ListBox();
            lblSo = new Label();
            btnXem = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 0;
            label1.Text = "Chon bang cuu chuong";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(76, 54);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 39);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.Yellow;
            btnTinh.Location = new Point(509, 51);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(99, 42);
            btnTinh.TabIndex = 3;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(403, 128);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(100, 32);
            lblKQ.TabIndex = 4;
            lblKQ.Text = "Ket Qua";
            lblKQ.Click += label2_Click;
            // 
            // txtChon
            // 
            txtChon.Location = new Point(18, 56);
            txtChon.Name = "txtChon";
            txtChon.Size = new Size(45, 39);
            txtChon.TabIndex = 5;
            txtChon.TextChanged += txtChon_TextChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo9);
            groupBox1.Controls.Add(rdo8);
            groupBox1.Controls.Add(rdo7);
            groupBox1.Controls.Add(rdo6);
            groupBox1.Controls.Add(rdo5);
            groupBox1.Controls.Add(rdo4);
            groupBox1.Controls.Add(rdo3);
            groupBox1.Controls.Add(rdo2);
            groupBox1.Location = new Point(12, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 122);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Box";
            // 
            // rdo9
            // 
            rdo9.AutoSize = true;
            rdo9.Location = new Point(190, 80);
            rdo9.Name = "rdo9";
            rdo9.Size = new Size(45, 36);
            rdo9.TabIndex = 0;
            rdo9.TabStop = true;
            rdo9.Text = "9";
            rdo9.UseVisualStyleBackColor = true;
            rdo9.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo8
            // 
            rdo8.AutoSize = true;
            rdo8.Location = new Point(125, 80);
            rdo8.Name = "rdo8";
            rdo8.Size = new Size(45, 36);
            rdo8.TabIndex = 0;
            rdo8.TabStop = true;
            rdo8.Text = "8";
            rdo8.UseVisualStyleBackColor = true;
            rdo8.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo7
            // 
            rdo7.AutoSize = true;
            rdo7.Location = new Point(64, 80);
            rdo7.Name = "rdo7";
            rdo7.Size = new Size(45, 36);
            rdo7.TabIndex = 0;
            rdo7.TabStop = true;
            rdo7.Text = "7";
            rdo7.UseVisualStyleBackColor = true;
            rdo7.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo6
            // 
            rdo6.AutoSize = true;
            rdo6.Location = new Point(6, 80);
            rdo6.Name = "rdo6";
            rdo6.Size = new Size(45, 36);
            rdo6.TabIndex = 0;
            rdo6.TabStop = true;
            rdo6.Text = "6";
            rdo6.UseVisualStyleBackColor = true;
            rdo6.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo5
            // 
            rdo5.AutoSize = true;
            rdo5.Location = new Point(190, 38);
            rdo5.Name = "rdo5";
            rdo5.Size = new Size(45, 36);
            rdo5.TabIndex = 0;
            rdo5.TabStop = true;
            rdo5.Text = "5";
            rdo5.UseVisualStyleBackColor = true;
            rdo5.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo4
            // 
            rdo4.AutoSize = true;
            rdo4.Location = new Point(125, 38);
            rdo4.Name = "rdo4";
            rdo4.Size = new Size(45, 36);
            rdo4.TabIndex = 0;
            rdo4.TabStop = true;
            rdo4.Text = "4";
            rdo4.UseVisualStyleBackColor = true;
            rdo4.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo3
            // 
            rdo3.AutoSize = true;
            rdo3.Location = new Point(64, 38);
            rdo3.Name = "rdo3";
            rdo3.Size = new Size(45, 36);
            rdo3.TabIndex = 0;
            rdo3.TabStop = true;
            rdo3.Text = "3";
            rdo3.UseVisualStyleBackColor = true;
            rdo3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(6, 38);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(45, 36);
            rdo2.TabIndex = 0;
            rdo2.TabStop = true;
            rdo2.Text = "2";
            rdo2.UseVisualStyleBackColor = true;
            rdo2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(161, 54);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(303, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(552, 128);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(146, 324);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblSo
            // 
            lblSo.AutoSize = true;
            lblSo.Location = new Point(659, 56);
            lblSo.Name = "lblSo";
            lblSo.Size = new Size(21, 32);
            lblSo.TabIndex = 9;
            lblSo.Text = " ";
            // 
            // btnXem
            // 
            btnXem.Location = new Point(12, 256);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(96, 45);
            btnXem.TabIndex = 10;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(733, 465);
            Controls.Add(btnXem);
            Controls.Add(lblSo);
            Controls.Add(listBox1);
            Controls.Add(trackBar1);
            Controls.Add(groupBox1);
            Controls.Add(txtChon);
            Controls.Add(lblKQ);
            Controls.Add(btnTinh);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button btnTinh;
        private Label lblKQ;
        private TextBox txtChon;
        private GroupBox groupBox1;
        private RadioButton rdo2;
        private RadioButton rdo9;
        private RadioButton rdo8;
        private RadioButton rdo7;
        private RadioButton rdo6;
        private RadioButton rdo5;
        private RadioButton rdo4;
        private RadioButton rdo3;
        private TrackBar trackBar1;
        private ListBox listBox1;
        private Label lblSo;
        private Button btnXem;
    }
}
