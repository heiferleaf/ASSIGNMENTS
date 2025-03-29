using HW6.Core.Service;
using HW6.Core.Model;

namespace OrderManagement.UI
{
    public partial class MainWindow : Form
    {
        public int selectedOrderId;
        public OrderService orderService = new OrderService();
        public BindingSource orderBinding = new BindingSource();


        public MainWindow()
        {
            InitializeComponent();
            // 模拟插入数据
            orderService.AddOrder(1, new OrderDetails("Product1", "Client1", 1.0));
            orderService.AddOrder(2, new OrderDetails("Product2", "Client2", 2.0));
            orderService.AddOrder(3, new OrderDetails("Product3", "Client3", 3.0));
            orderService.AddOrder(4, new OrderDetails("Product4", "Client4", 4.0));
            // 数据绑定，将需要显示的数据绑定在BindingSource上，再将BindingSource绑定在DataGridView上
            orderBinding.DataSource = orderService.Orders;
            DataShow.DataSource = orderBinding;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectInput_TextChanged(object sender, EventArgs e)
        {
            if (selectInput.Text == "")
            {
                orderBinding.DataSource = orderService.Orders;
                selectedOrderId = -1;
                return;
            }
            selectedOrderId = Convert.ToInt32(selectInput.Text);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Order order;
            try
            {
                order = orderService.SelectOrder(selectedOrderId);
                orderBinding.DataSource = order;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            // 创建子窗口用来新建订单
            NewWindow newWindow = new NewWindow(this);
            newWindow.FormClosed += (s, args) =>
            {
                orderBinding.DataSource = null;
                orderBinding.DataSource = orderService.Orders;
                orderBinding.ResetBindings(false);
            };
            newWindow.Show();
            return;
        }

        private void UpdateOrderButon_Click(object sender, EventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow(this);
            updateWindow.FormClosed += (s, args) =>
            {
                orderBinding.DataSource = null;
                orderBinding.DataSource = orderService.Orders;
                orderBinding.ResetBindings(false);
            };
            updateWindow.Show();
            return;
        }
    }
}
