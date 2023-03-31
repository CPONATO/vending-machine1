using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vending_machine1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {
            if (checkedListPay.CheckedItems.Contains("Credit card"))
            {
                // Open Credit Card form
                CreditCard ccForm = new CreditCard();
                ccForm.Show();
            }
            else if (checkedListPay.CheckedItems.Contains("QR pay"))
            {
                // Open QR code form
                QRpay qrForm = new QRpay();
                qrForm.Show();
            }
        }
    }
}
