using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW6.Core.Model;

namespace OrderManagement.UI
{
    public partial class UpdateWindow : Form
    {
        private int updateOrderId;
        private string updateOrderName;
        private string updateOrderClient;
        private Double updateOrderPrice;
        private MainWindow _mw;
        private BindingSource orderBinding = new BindingSource();

        public UpdateWindow(MainWindow mw)
        {
            InitializeComponent();
            updateOrderName = "";
            updateOrderClient = "";
            updateOrderPrice = 0;
            _mw = mw;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                updateOrderId = Convert.ToInt32(textBox1.Text);
                Order order = _mw.orderService.SelectOrder(updateOrderId);
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateOrderName = textBox2.Text;
            updateOrderClient = textBox1.Text;
            try
            {
                updateOrderPrice = Convert.ToDouble(textBox4.Text);
                _mw.orderService.UpdateOrder(updateOrderId, new OrderDetails(updateOrderName, updateOrderClient, updateOrderPrice));
                _mw.orderBinding.ResetBindings(false);
                this.Close();
            }
            catch
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                updateOrderId = Convert.ToInt32(textBox1.Text);
                Order updateOrder = _mw.orderService.SelectOrder(updateOrderId);
                orderBinding.DataSource = updateOrder;
                OrderShowDate.DataSource = orderBinding;
            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
