using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchase
{
    public partial class TicketPurchaseUI : Form
    {
        public TicketPurchaseUI()
        {
            InitializeComponent();
        }
        private int unitPrice = 100;
        private string customerName;
        private int numberOfTicket, totalPrice;

        private void detailsButton_Click(object sender, EventArgs e)
        {
            Pupolate();
            string messageOutput = "Cutomer Name: " + customerName + Environment.NewLine + "Unit Price: " + unitPrice + Environment.NewLine + "Total Price: " + totalPrice;
            MessageBox.Show(messageOutput);
        }


        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            Pupolate();
            string messageOutput = customerName + ", You have to Pay " + totalPrice + " Taka.";
            MessageBox.Show(messageOutput);
        }


        public void Pupolate()
        {
            customerName = customerNameTextBox.Text;
            numberOfTicket = Convert.ToInt32(numberOfTicketTextBox.Text);
            totalPrice = numberOfTicket * unitPrice;
        }
    }
}
