namespace OrderManagement.UI
{
    partial class MainWindow
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
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            selectLabel = new Label();
            selectInput = new TextBox();
            selectButton = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            newOrderButton = new Button();
            UpdateOrderButon = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            DataShow = new DataGridView();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataShow).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel3.Location = new Point(94, 41);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1420, 773);
            flowLayoutPanel3.TabIndex = 4;
            flowLayoutPanel3.Paint += flowLayoutPanel3_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(selectLabel);
            flowLayoutPanel1.Controls.Add(selectInput);
            flowLayoutPanel1.Controls.Add(selectButton);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(622, 61);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Location = new Point(3, 0);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(231, 31);
            selectLabel.TabIndex = 0;
            selectLabel.Text = "根据订单ID进行查询";
            selectLabel.Click += label1_Click;
            // 
            // selectInput
            // 
            selectInput.Location = new Point(240, 3);
            selectInput.Name = "selectInput";
            selectInput.Size = new Size(200, 38);
            selectInput.TabIndex = 1;
            selectInput.TextChanged += selectInput_TextChanged;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(446, 3);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(150, 46);
            selectButton.TabIndex = 2;
            selectButton.Text = "查询";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(newOrderButton);
            flowLayoutPanel4.Controls.Add(UpdateOrderButon);
            flowLayoutPanel4.Location = new Point(631, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(760, 61);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // newOrderButton
            // 
            newOrderButton.Location = new Point(103, 3);
            newOrderButton.Margin = new Padding(103, 3, 103, 3);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Size = new Size(150, 46);
            newOrderButton.TabIndex = 0;
            newOrderButton.Text = "新建订单";
            newOrderButton.UseVisualStyleBackColor = true;
            newOrderButton.Click += newOrderButton_Click;
            // 
            // UpdateOrderButon
            // 
            UpdateOrderButon.Location = new Point(359, 3);
            UpdateOrderButon.Name = "UpdateOrderButon";
            UpdateOrderButon.Size = new Size(150, 46);
            UpdateOrderButon.TabIndex = 1;
            UpdateOrderButon.Text = "修改订单";
            UpdateOrderButon.UseVisualStyleBackColor = true;
            UpdateOrderButon.Click += UpdateOrderButon_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(DataShow);
            flowLayoutPanel2.Location = new Point(3, 70);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1417, 703);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // DataShow
            // 
            DataShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataShow.Location = new Point(3, 3);
            DataShow.Name = "DataShow";
            DataShow.RowHeadersWidth = 82;
            DataShow.Size = new Size(1414, 700);
            DataShow.TabIndex = 2;
            DataShow.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 901);
            Controls.Add(flowLayoutPanel3);
            Name = "MainWindow";
            Text = "Form1";
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label selectLabel;
        private TextBox selectInput;
        private Button selectButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridView DataShow;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button newOrderButton;
        private Button UpdateOrderButon;
    }
}
