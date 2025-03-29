namespace OrderManagement.UI
{
    partial class NewWindow
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
            button1 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Location = new Point(207, 90);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(818, 452);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(698, 57);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 0;
            label1.Text = "输入新建记录";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(167, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(textBox1);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(textBox2);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(textBox3);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(textBox4);
            flowLayoutPanel3.Location = new Point(3, 66);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(349, 386);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 31);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 38);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 2;
            label3.Text = "订单名称";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 38);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 88);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 4;
            label4.Text = "订单客户";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 38);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 5;
            label5.Text = "订单价格";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 38);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // NewWindow
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 648);
            Controls.Add(flowLayoutPanel1);
            Name = "NewWindow";
            Text = "NewWindow";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
    }
}