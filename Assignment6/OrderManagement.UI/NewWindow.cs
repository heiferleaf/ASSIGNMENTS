using HW6.Core.Model;
using HW6.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.UI
{
    public partial class NewWindow : Form
    {
        private int newOrderId;
        private string newOrderName;
        private string newOrderClient;
        private Double newOrderPrice;

        private MainWindow _mw;


        public NewWindow(MainWindow mw)
        {
            InitializeComponent();
            _mw = mw;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                return;
            }
            newOrderClient = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                return;
            }
            try
            {
                newOrderPrice = Convert.ToDouble(textBox4.Text);
            }catch
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            try
            {
                newOrderId = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                Console.WriteLine("Invalid Order ID");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                return;
            }
            newOrderName = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetails od = new OrderDetails(newOrderName, newOrderClient, newOrderPrice);
            _mw.orderService.AddOrder(newOrderId, od);
            _mw.orderBinding.ResetBindings(false);

            this.Close();
        }
    }
}
