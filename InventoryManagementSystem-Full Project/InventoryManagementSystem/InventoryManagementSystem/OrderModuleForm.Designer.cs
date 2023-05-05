namespace InventoryManagementSystem
{
    partial class OrderModuleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 53);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBoxClose.Image = global::InventoryManagementSystem.Properties.Resources.icons8_close_window_50;
            this.pictureBoxClose.Location = new System.Drawing.Point(1069, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 11;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Module";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOid);
            this.panel2.Controls.Add(this.txtCName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvCustomer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSearchCust);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 601);
            this.panel2.TabIndex = 5;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(16, 425);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(302, 30);
            this.txtCName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer Name:";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(16, 359);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(302, 30);
            this.txtCid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Id:";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomer.ColumnHeadersHeight = 34;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 62;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(360, 234);
            this.dgvCustomer.TabIndex = 10;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "No.";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 74;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Customer Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 152;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search Box";
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Location = new System.Drawing.Point(187, 245);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(165, 30);
            this.txtSearchCust.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(7, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "CUSTOMER";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.dtOrder);
            this.panel3.Controls.Add(this.txtPName);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtPid);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtSearchProd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgvProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(367, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 601);
            this.panel3.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(555, 384);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 30);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(576, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 39);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(437, 550);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(133, 39);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "Order Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Order Date:";
            // 
            // dtOrder
            // 
            this.dtOrder.CustomFormat = "dd/MM/yyyy";
            this.dtOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOrder.Location = new System.Drawing.Point(17, 492);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(236, 30);
            this.dtOrder.TabIndex = 23;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(17, 425);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(236, 30);
            this.txtPName.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Product Name:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(555, 420);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(151, 30);
            this.txtTotal.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Qty:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(555, 348);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 30);
            this.txtPrice.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Price:";
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(17, 359);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(236, 30);
            this.txtPid.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Product Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search Box";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Location = new System.Drawing.Point(292, 248);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(414, 30);
            this.txtSearchProd.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(3, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRODUCT";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProduct.ColumnHeadersHeight = 34;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(734, 234);
            this.dgvProduct.TabIndex = 7;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 136;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 87;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Category";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.Location = new System.Drawing.Point(12, 550);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(82, 21);
            this.lblOid.TabIndex = 15;
            this.lblOid.Text = "Order Id";
            this.lblOid.Visible = false;
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Label lblOid;
        public System.Windows.Forms.TextBox txtCName;
        public System.Windows.Forms.TextBox txtCid;
        public System.Windows.Forms.TextBox txtPName;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtPid;
        public System.Windows.Forms.DateTimePicker dtOrder;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}