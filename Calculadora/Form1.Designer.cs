namespace Calculadora
{
    partial class calculadora1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btigual = new Label();
            btvirgula = new Label();
            bt3 = new Label();
            bt2 = new Label();
            bt1 = new Label();
            bt6 = new Label();
            bt5 = new Label();
            bt4 = new Label();
            bt9 = new Label();
            bt8 = new Label();
            bt7 = new Label();
            bt0 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            btC = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MidnightBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btigual, 2, 3);
            tableLayoutPanel1.Controls.Add(btvirgula, 0, 3);
            tableLayoutPanel1.Controls.Add(bt3, 2, 2);
            tableLayoutPanel1.Controls.Add(bt2, 1, 2);
            tableLayoutPanel1.Controls.Add(bt1, 0, 2);
            tableLayoutPanel1.Controls.Add(bt6, 2, 1);
            tableLayoutPanel1.Controls.Add(bt5, 1, 1);
            tableLayoutPanel1.Controls.Add(bt4, 0, 1);
            tableLayoutPanel1.Controls.Add(bt9, 2, 0);
            tableLayoutPanel1.Controls.Add(bt8, 1, 0);
            tableLayoutPanel1.Controls.Add(bt7, 0, 0);
            tableLayoutPanel1.Controls.Add(bt0, 1, 3);
            tableLayoutPanel1.Location = new Point(0, 220);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(347, 366);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btigual
            // 
            btigual.Anchor = AnchorStyles.None;
            btigual.AutoSize = true;
            btigual.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btigual.ForeColor = SystemColors.Control;
            btigual.Location = new Point(264, 227);
            btigual.Name = "btigual";
            btigual.Size = new Size(48, 57);
            btigual.TabIndex = 11;
            btigual.Text = "=";
            btigual.Click += btigual_Click;
            // 
            // btvirgula
            // 
            btvirgula.Anchor = AnchorStyles.None;
            btvirgula.AutoSize = true;
            btvirgula.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btvirgula.ForeColor = SystemColors.Control;
            btvirgula.Location = new Point(39, 227);
            btvirgula.Name = "btvirgula";
            btvirgula.Size = new Size(36, 57);
            btvirgula.TabIndex = 10;
            btvirgula.Text = ",";
            btvirgula.Click += btvirgula_Click;
            // 
            // bt3
            // 
            bt3.Anchor = AnchorStyles.None;
            bt3.AutoSize = true;
            bt3.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt3.ForeColor = SystemColors.Control;
            bt3.Location = new Point(265, 154);
            bt3.Name = "bt3";
            bt3.Size = new Size(47, 57);
            bt3.TabIndex = 8;
            bt3.Text = "3";
            bt3.Click += bt3_Click;
            // 
            // bt2
            // 
            bt2.Anchor = AnchorStyles.None;
            bt2.AutoSize = true;
            bt2.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt2.ForeColor = SystemColors.Control;
            bt2.Location = new Point(149, 154);
            bt2.Name = "bt2";
            bt2.Size = new Size(47, 57);
            bt2.TabIndex = 7;
            bt2.Text = "2";
            bt2.Click += bt2_Click;
            // 
            // bt1
            // 
            bt1.Anchor = AnchorStyles.None;
            bt1.AutoSize = true;
            bt1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt1.ForeColor = SystemColors.Control;
            bt1.Location = new Point(34, 154);
            bt1.Name = "bt1";
            bt1.Size = new Size(47, 57);
            bt1.TabIndex = 6;
            bt1.Text = "1";
            bt1.Click += bt1_Click;
            // 
            // bt6
            // 
            bt6.Anchor = AnchorStyles.None;
            bt6.AutoSize = true;
            bt6.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt6.ForeColor = SystemColors.Control;
            bt6.Location = new Point(265, 81);
            bt6.Name = "bt6";
            bt6.Size = new Size(47, 57);
            bt6.TabIndex = 5;
            bt6.Text = "6";
            bt6.Click += bt6_Click;
            // 
            // bt5
            // 
            bt5.Anchor = AnchorStyles.None;
            bt5.AutoSize = true;
            bt5.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt5.ForeColor = SystemColors.Control;
            bt5.Location = new Point(149, 81);
            bt5.Name = "bt5";
            bt5.Size = new Size(47, 57);
            bt5.TabIndex = 4;
            bt5.Text = "5";
            bt5.Click += bt5_Click;
            // 
            // bt4
            // 
            bt4.Anchor = AnchorStyles.None;
            bt4.AutoSize = true;
            bt4.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt4.ForeColor = SystemColors.Control;
            bt4.Location = new Point(34, 81);
            bt4.Name = "bt4";
            bt4.Size = new Size(47, 57);
            bt4.TabIndex = 3;
            bt4.Text = "4";
            bt4.Click += bt4_Click;
            // 
            // bt9
            // 
            bt9.Anchor = AnchorStyles.None;
            bt9.AutoSize = true;
            bt9.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt9.ForeColor = SystemColors.Control;
            bt9.Location = new Point(265, 8);
            bt9.Name = "bt9";
            bt9.Size = new Size(47, 57);
            bt9.TabIndex = 2;
            bt9.Text = "9";
            bt9.Click += bt9_Click;
            // 
            // bt8
            // 
            bt8.Anchor = AnchorStyles.None;
            bt8.AutoSize = true;
            bt8.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt8.ForeColor = SystemColors.Control;
            bt8.Location = new Point(149, 8);
            bt8.Name = "bt8";
            bt8.Size = new Size(47, 57);
            bt8.TabIndex = 1;
            bt8.Text = "8";
            bt8.Click += bt8_Click;
            // 
            // bt7
            // 
            bt7.Anchor = AnchorStyles.None;
            bt7.AutoSize = true;
            bt7.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt7.ForeColor = SystemColors.Control;
            bt7.Location = new Point(34, 8);
            bt7.Name = "bt7";
            bt7.Size = new Size(47, 57);
            bt7.TabIndex = 0;
            bt7.Text = "7";
            bt7.Click += bt7_Click;
            // 
            // bt0
            // 
            bt0.Anchor = AnchorStyles.None;
            bt0.AutoSize = true;
            bt0.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt0.ForeColor = SystemColors.Control;
            bt0.Location = new Point(149, 227);
            bt0.Name = "bt0";
            bt0.Size = new Size(47, 57);
            bt0.TabIndex = 9;
            bt0.Text = "0";
            bt0.Click += bt0_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Navy;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(btC, 0, 0);
            tableLayoutPanel2.Location = new Point(347, 220);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(116, 366);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(40, 300);
            label7.Name = "label7";
            label7.Size = new Size(36, 57);
            label7.TabIndex = 14;
            label7.Text = "/";
            // 
            // btC
            // 
            btC.Anchor = AnchorStyles.None;
            btC.AutoSize = true;
            btC.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btC.ForeColor = SystemColors.Control;
            btC.Location = new Point(31, 8);
            btC.Name = "btC";
            btC.Size = new Size(53, 57);
            btC.TabIndex = 10;
            btC.Text = "C";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 225);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 71);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(311, 58);
            label3.Name = "label3";
            label3.Size = new Size(53, 57);
            label3.TabIndex = 13;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(370, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 57);
            label2.TabIndex = 12;
            label2.Text = "C";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(252, 58);
            label1.Name = "label1";
            label1.Size = new Size(53, 57);
            label1.TabIndex = 11;
            label1.Text = "C";
            // 
            // calculadora1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 582);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "calculadora1";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label bt7;
        private Label bt3;
        private Label bt2;
        private Label bt1;
        private Label bt6;
        private Label bt5;
        private Label bt4;
        private Label bt9;
        private Label bt8;
        private Label bt0;
        private Label btigual;
        private Label btvirgula;
        private Label label7;
        private Label btC;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
