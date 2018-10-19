namespace PLPMonitoria
{
    partial class newOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.foodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apollo15DataSet2 = new PLPMonitoria.Apollo15DataSet2();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetails = new System.Windows.Forms.Label();
            this.numFood = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDrink = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.apollo15DataSet = new PLPMonitoria.Apollo15DataSet();
            this.apollo15DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apollo15DataSet1 = new PLPMonitoria.Apollo15DataSet1();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new PLPMonitoria.Apollo15DataSet1TableAdapters.FoodTableAdapter();
            this.foodTableAdapter1 = new PLPMonitoria.Apollo15DataSet2TableAdapters.FoodTableAdapter();
            this.apollo15DataSet3 = new PLPMonitoria.Apollo15DataSet3();
            this.drinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinkTableAdapter = new PLPMonitoria.Apollo15DataSet3TableAdapters.DrinkTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFood
            // 
            this.cmbFood.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFood.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.foodBindingSource1, "nome", true));
            this.cmbFood.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodBindingSource1, "nome", true));
            this.cmbFood.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.foodBindingSource1, "nome", true));
            this.cmbFood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource1, "nome", true));
            this.cmbFood.DisplayMember = "nome";
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(59, 124);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(145, 21);
            this.cmbFood.TabIndex = 1;
            this.cmbFood.ValueMember = "nome";
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // foodBindingSource1
            // 
            this.foodBindingSource1.DataMember = "Food";
            this.foodBindingSource1.DataSource = this.apollo15DataSet2;
            // 
            // apollo15DataSet2
            // 
            this.apollo15DataSet2.DataSetName = "Apollo15DataSet2";
            this.apollo15DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Minimizar a janela";
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(859, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 39);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Fechar a janela";
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(903, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 39);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(836, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apollo 15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(841, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label3.Location = new System.Drawing.Point(55, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pratos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // dataOrder
            // 
            this.dataOrder.AllowUserToAddRows = false;
            this.dataOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(79)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataOrder.ColumnHeadersHeight = 27;
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.Preço});
            this.dataOrder.Location = new System.Drawing.Point(476, 124);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.ReadOnly = true;
            this.dataOrder.RowHeadersWidth = 30;
            this.dataOrder.Size = new System.Drawing.Size(465, 181);
            this.dataOrder.TabIndex = 20;
            this.dataOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrder_CellContentClick);
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Produto.FillWeight = 105F;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Produto.Width = 205;
            // 
            // Quantidade
            // 
            this.Quantidade.FillWeight = 105F;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantidade.Width = 120;
            // 
            // Preço
            // 
            this.Preço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Preço.FillWeight = 105F;
            this.Preço.HeaderText = "Preço unit.";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Preço.Width = 110;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.lblDetails.Location = new System.Drawing.Point(471, 94);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(203, 27);
            this.lblDetails.TabIndex = 21;
            this.lblDetails.Text = "Detalhes do pedido";
            this.lblDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // numFood
            // 
            this.numFood.Location = new System.Drawing.Point(259, 125);
            this.numFood.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFood.Name = "numFood";
            this.numFood.Size = new System.Drawing.Size(96, 20);
            this.numFood.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label4.Location = new System.Drawing.Point(255, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label5.Location = new System.Drawing.Point(255, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantidade";
            // 
            // numDrink
            // 
            this.numDrink.Location = new System.Drawing.Point(259, 216);
            this.numDrink.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDrink.Name = "numDrink";
            this.numDrink.Size = new System.Drawing.Size(96, 20);
            this.numDrink.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label6.Location = new System.Drawing.Point(55, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Bebidas";
            // 
            // cmbDrink
            // 
            this.cmbDrink.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(59, 216);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(145, 21);
            this.cmbDrink.TabIndex = 24;
            this.cmbDrink.SelectedIndexChanged += new System.EventHandler(this.cmbDrink_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "Adiconar a lista de pedidos";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(17, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 32);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label7.Location = new System.Drawing.Point(55, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mesa";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(59, 295);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(78, 20);
            this.txtTable.TabIndex = 31;
            this.txtTable.TextChanged += new System.EventHandler(this.txtTable_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 283);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(176, 283);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 295);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label8.Location = new System.Drawing.Point(214, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nome";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleDescription = "Finalizar pedido";
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(230, 370);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(125, 32);
            this.btnFinalizar.TabIndex = 36;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Novo pedido";
            // 
            // apollo15DataSet
            // 
            this.apollo15DataSet.DataSetName = "Apollo15DataSet";
            this.apollo15DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apollo15DataSetBindingSource
            // 
            this.apollo15DataSetBindingSource.DataSource = this.apollo15DataSet;
            this.apollo15DataSetBindingSource.Position = 0;
            // 
            // apollo15DataSet1
            // 
            this.apollo15DataSet1.DataSetName = "Apollo15DataSet1";
            this.apollo15DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.apollo15DataSet1;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // foodTableAdapter1
            // 
            this.foodTableAdapter1.ClearBeforeFill = true;
            // 
            // apollo15DataSet3
            // 
            this.apollo15DataSet3.DataSetName = "Apollo15DataSet3";
            this.apollo15DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drinkBindingSource
            // 
            this.drinkBindingSource.DataMember = "Drink";
            this.drinkBindingSource.DataSource = this.apollo15DataSet3;
            // 
            // drinkTableAdapter
            // 
            this.drinkTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.AccessibleDescription = "Voltar ao menu principal";
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(11, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 39);
            this.btnBack.TabIndex = 38;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "Deleta um pedido";
            this.btnDelete.AccessibleName = "Deleta um pedido";
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(661, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 39);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = "Edita um pedido";
            this.btnEdit.AccessibleName = "Edita um pedido";
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(725, 311);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 39);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.lblTotal.Location = new System.Drawing.Point(471, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 27);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total: R$ 0,00";
            // 
            // newOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 479);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDrink);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numFood);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.dataOrder);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.newOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apollo15DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.NumericUpDown numFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDrink;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource apollo15DataSetBindingSource;
		private Apollo15DataSet apollo15DataSet;
		private Apollo15DataSet1 apollo15DataSet1;
		private System.Windows.Forms.BindingSource foodBindingSource;
		private Apollo15DataSet1TableAdapters.FoodTableAdapter foodTableAdapter;
		private Apollo15DataSet2 apollo15DataSet2;
		private System.Windows.Forms.BindingSource foodBindingSource1;
		private Apollo15DataSet2TableAdapters.FoodTableAdapter foodTableAdapter1;
		private Apollo15DataSet3 apollo15DataSet3;
		private System.Windows.Forms.BindingSource drinkBindingSource;
		private Apollo15DataSet3TableAdapters.DrinkTableAdapter drinkTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
		private System.Windows.Forms.ComboBox cmbFood;
		private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTotal;
    }
}