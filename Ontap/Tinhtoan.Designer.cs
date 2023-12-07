namespace Ontap
{
    partial class Tinhtoan
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
            btCong = new Button();
            lbTinh = new Label();
            txtB = new TextBox();
            lbKq = new Label();
            lbB = new Label();
            lbA = new Label();
            txtA = new TextBox();
            txtKq = new TextBox();
            SuspendLayout();
            // 
            // btCong
            // 
            btCong.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btCong.Location = new Point(317, 241);
            btCong.Name = "btCong";
            btCong.Size = new Size(107, 48);
            btCong.TabIndex = 0;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            // 
            // lbTinh
            // 
            lbTinh.AutoSize = true;
            lbTinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTinh.Location = new Point(80, 40);
            lbTinh.Name = "lbTinh";
            lbTinh.Size = new Size(92, 25);
            lbTinh.TabIndex = 1;
            lbTinh.Text = "Tính toán";
            // 
            // txtB
            // 
            txtB.Location = new Point(146, 143);
            txtB.Name = "txtB";
            txtB.Size = new Size(278, 23);
            txtB.TabIndex = 2;
            txtB.TextChanged += textBox1_TextChanged;
            // 
            // lbKq
            // 
            lbKq.AutoSize = true;
            lbKq.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbKq.Location = new Point(29, 196);
            lbKq.Name = "lbKq";
            lbKq.Size = new Size(76, 25);
            lbKq.TabIndex = 3;
            lbKq.Text = "Kết quả";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbB.Location = new Point(29, 143);
            lbB.Name = "lbB";
            lbB.Size = new Size(49, 25);
            lbB.TabIndex = 4;
            lbB.Text = "Số B";
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbA.Location = new Point(29, 91);
            lbA.Name = "lbA";
            lbA.Size = new Size(50, 25);
            lbA.TabIndex = 5;
            lbA.Text = "Số A";
            // 
            // txtA
            // 
            txtA.Location = new Point(146, 96);
            txtA.Name = "txtA";
            txtA.Size = new Size(278, 23);
            txtA.TabIndex = 2;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // txtKq
            // 
            txtKq.Location = new Point(146, 196);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(278, 23);
            txtKq.TabIndex = 2;
            txtKq.TextChanged += textBox1_TextChanged;
            // 
            // Tinhtoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(lbA);
            Controls.Add(lbB);
            Controls.Add(lbKq);
            Controls.Add(txtKq);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(lbTinh);
            Controls.Add(btCong);
            Name = "Tinhtoan";
            Text = "Tinhtoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCong;
        private Label lbTinh;
        private TextBox txtB;
        private Label lbKq;
        private Label lbB;
        private Label lbA;
        private TextBox txtA;
        private TextBox txtKq;
    }
}