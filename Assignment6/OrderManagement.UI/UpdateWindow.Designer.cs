namespace OrderManagement.UI
{
    partial class UpdateWindow
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            OrderShowDate = new DataGridView();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label5 = new Label();
            textBox3 = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label6 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderShowDate).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Location = new Point(254, 138);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(909, 507);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(906, 85);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Margin = new Padding(30, 25, 25, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 0;
            label1.Text = "请输入要修改的订单ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(313, 25);
            textBox1.Margin = new Padding(3, 25, 25, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 38);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(OrderShowDate);
            flowLayoutPanel3.Location = new Point(3, 121);
            flowLayoutPanel3.Margin = new Padding(3, 30, 3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(906, 121);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 1;
            label2.Text = "待修改的订单信息";
            // 
            // OrderShowDate
            // 
            OrderShowDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderShowDate.Dock = DockStyle.Bottom;
            OrderShowDate.Location = new Point(3, 34);
            OrderShowDate.Name = "OrderShowDate";
            OrderShowDate.RowHeadersWidth = 82;
            OrderShowDate.Size = new Size(903, 82);
            OrderShowDate.TabIndex = 0;
            OrderShowDate.CellContentClick += dataGridView1_CellContentClick;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel4.Controls.Add(button2);
            flowLayoutPanel4.Location = new Point(3, 248);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(906, 259);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 31);
            label3.TabIndex = 0;
            label3.Text = "请输入修改的信息";
            label3.Click += label3_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(textBox2);
            flowLayoutPanel5.Location = new Point(3, 34);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(898, 54);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 10);
            label4.Margin = new Padding(3, 10, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 31);
            label4.TabIndex = 0;
            label4.Text = "修改的产品名称";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 38);
            textBox2.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label5);
            flowLayoutPanel6.Controls.Add(textBox3);
            flowLayoutPanel6.Location = new Point(3, 94);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(900, 62);
            flowLayoutPanel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 10);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 31);
            label5.TabIndex = 0;
            label5.Text = "修改的产品客户";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 38);
            textBox3.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label6);
            flowLayoutPanel7.Controls.Add(textBox4);
            flowLayoutPanel7.Location = new Point(3, 162);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(898, 52);
            flowLayoutPanel7.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 10);
            label6.Margin = new Padding(3, 10, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 31);
            label6.TabIndex = 0;
            label6.Text = "修改的产品价格";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(191, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 38);
            textBox4.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(3, 220);
            button2.Name = "button2";
            button2.Size = new Size(150, 39);
            button2.TabIndex = 4;
            button2.Text = "确认提交";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UpdateWindow
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 823);
            Controls.Add(flowLayoutPanel1);
            Name = "UpdateWindow";
            Text = "UptateWindow";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderShowDate).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private DataGridView OrderShowDate;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}