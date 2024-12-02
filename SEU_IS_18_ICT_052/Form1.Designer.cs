namespace SEU_IS_18_ICT_052
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
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            cmbBookName = new ComboBox();
            cmbMembership = new ComboBox();
            btnCalculate = new Button();
            btnClear = new Button();
            rtbBill = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 126);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 193);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 263);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Membership Status";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(195, 190);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 27);
            txtQuantity.TabIndex = 3;
            // 
            // cmbBookName
            // 
            cmbBookName.FormattingEnabled = true;
            cmbBookName.Items.AddRange(new object[] { "The Lord of the Rings - $19.99", "Harry Potter and the Sorcerer's Stone - $12.99", "Pride and Prejudice - $8.99", "To Kill a Mockingbird - $11.99", "The Great Gatsby - $9.99", "The Catcher in the Rye - $10.99", "1984 - $7.99", "The Hitchhiker's Guide to the Galaxy - $14.99", "The Alchemist - $12.99", "The Silent Patient - $16.99" });
            cmbBookName.Location = new Point(195, 126);
            cmbBookName.Name = "cmbBookName";
            cmbBookName.Size = new Size(411, 28);
            cmbBookName.TabIndex = 4;
            // 
            // cmbMembership
            // 
            cmbMembership.FormattingEnabled = true;
            cmbMembership.Items.AddRange(new object[] { "Club Member", "Non-Member" });
            cmbMembership.Location = new Point(195, 260);
            cmbMembership.Name = "cmbMembership";
            cmbMembership.Size = new Size(201, 28);
            cmbMembership.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(0, 117, 214);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.WhiteSmoke;
            btnCalculate.Location = new Point(195, 353);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(139, 58);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate Bill";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(247, 55, 55);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.Location = new Point(391, 353);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 58);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // rtbBill
            // 
            rtbBill.Location = new Point(611, 190);
            rtbBill.Name = "rtbBill";
            rtbBill.Size = new Size(287, 300);
            rtbBill.TabIndex = 8;
            rtbBill.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(276, 25);
            label4.Name = "label4";
            label4.Size = new Size(348, 38);
            label4.TabIndex = 9;
            label4.Text = "BookStore Billing System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 522);
            Controls.Add(label4);
            Controls.Add(rtbBill);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(cmbMembership);
            Controls.Add(cmbBookName);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuantity;
        private ComboBox cmbBookName;
        private ComboBox cmbMembership;
        private Button btnCalculate;
        private Button btnClear;
        private RichTextBox rtbBill;
        private Label label4;
    }
}
