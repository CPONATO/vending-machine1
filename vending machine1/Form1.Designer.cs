namespace vending_machine1
{
    partial class Form1
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
            this.TrainTicketVendor = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Book = new System.Windows.Forms.Button();
            this.checkedListPay = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // TrainTicketVendor
            // 
            this.TrainTicketVendor.AutoSize = true;
            this.TrainTicketVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TrainTicketVendor.Location = new System.Drawing.Point(148, 7);
            this.TrainTicketVendor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrainTicketVendor.Name = "TrainTicketVendor";
            this.TrainTicketVendor.Size = new System.Drawing.Size(211, 29);
            this.TrainTicketVendor.TabIndex = 0;
            this.TrainTicketVendor.Text = "Train ticket vendor";
            this.TrainTicketVendor.Click += new System.EventHandler(this.label1_Click);
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Destination.Location = new System.Drawing.Point(9, 140);
            this.Destination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(133, 29);
            this.Destination.TabIndex = 1;
            this.Destination.Text = "Destination";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Time.Location = new System.Drawing.Point(9, 68);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(69, 29);
            this.Time.TabIndex = 2;
            this.Time.Text = "Time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "7:00 am",
            "8:00 am",
            "9:00 am",
            "10:00 am",
            "11:00 am",
            "12:00 am",
            "2:00 pm",
            "3:00 pm",
            "4:00 pm",
            "5:00 pm"});
            this.comboBox1.Location = new System.Drawing.Point(14, 108);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hà Nội",
            "Nha Trang",
            "Khánh Hòa",
            "Vũng Tàu",
            "Bà Rịa",
            "Long Điền",
            "Phước Tỉnh"});
            this.comboBox2.Location = new System.Drawing.Point(14, 177);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(165, 224);
            this.Book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(150, 39);
            this.Book.TabIndex = 7;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // checkedListPay
            // 
            this.checkedListPay.FormattingEnabled = true;
            this.checkedListPay.Items.AddRange(new object[] {
            "QR pay",
            "Credit card"});
            this.checkedListPay.Location = new System.Drawing.Point(339, 135);
            this.checkedListPay.Name = "checkedListPay";
            this.checkedListPay.Size = new System.Drawing.Size(123, 34);
            this.checkedListPay.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 273);
            this.Controls.Add(this.checkedListPay);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.TrainTicketVendor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrainTicketVendor;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.CheckedListBox checkedListPay;
    }
}

