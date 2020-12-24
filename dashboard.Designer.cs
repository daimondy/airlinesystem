namespace airlinesystem
{
    partial class dashboard
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
            this.labelExit = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonAirplane = new System.Windows.Forms.Button();
            this.buttonAirline = new System.Windows.Forms.Button();
            this.buttonAirport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGrid = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.Airport_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airport_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counrty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.а = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
>>>>>>> 21729aab75e1fae98a5cce56a9dc10f8d8a7ffc5
            this.selectAttribute = new System.Windows.Forms.ComboBox();
            this.newValueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deletePromptLabel = new System.Windows.Forms.Label();
            this.deleteIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.deleteButtonCon = new System.Windows.Forms.Button();
            this.Airport_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airport_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counrty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.а = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.labelExit.Location = new System.Drawing.Point(1089, 27);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(31, 29);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.labelBack.Location = new System.Drawing.Point(44, 27);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(28, 29);
            this.labelBack.TabIndex = 4;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelExit);
            this.panel2.Controls.Add(this.labelBack);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-11, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 137);
            this.panel2.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 100);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label7.Location = new System.Drawing.Point(514, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Информационное табло";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label3.Location = new System.Drawing.Point(531, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Airline System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.buttonFlight);
            this.panel1.Controls.Add(this.buttonAirplane);
            this.panel1.Controls.Add(this.buttonAirline);
            this.panel1.Controls.Add(this.buttonAirport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 733);
            this.panel1.TabIndex = 63;
            // 
            // buttonFlight
            // 
            this.buttonFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFlight.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonFlight.Location = new System.Drawing.Point(12, 415);
            this.buttonFlight.Name = "buttonFlight";
            this.buttonFlight.Size = new System.Drawing.Size(171, 97);
            this.buttonFlight.TabIndex = 67;
            this.buttonFlight.Text = "Рейсы";
            this.buttonFlight.UseVisualStyleBackColor = true;
            this.buttonFlight.Click += new System.EventHandler(this.buttonFlight_Click);
            // 
            // buttonAirplane
            // 
            this.buttonAirplane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAirplane.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAirplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAirplane.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAirplane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonAirplane.Location = new System.Drawing.Point(12, 322);
            this.buttonAirplane.Name = "buttonAirplane";
            this.buttonAirplane.Size = new System.Drawing.Size(171, 97);
            this.buttonAirplane.TabIndex = 66;
            this.buttonAirplane.Text = "Самолеты";
            this.buttonAirplane.UseVisualStyleBackColor = true;
            this.buttonAirplane.Click += new System.EventHandler(this.buttonAirplane_Click);
            // 
            // buttonAirline
            // 
            this.buttonAirline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAirline.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAirline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAirline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonAirline.Location = new System.Drawing.Point(12, 228);
            this.buttonAirline.Name = "buttonAirline";
            this.buttonAirline.Size = new System.Drawing.Size(171, 97);
            this.buttonAirline.TabIndex = 65;
            this.buttonAirline.Text = "Авиакомпании";
            this.buttonAirline.UseVisualStyleBackColor = true;
            this.buttonAirline.Click += new System.EventHandler(this.buttonAirline_Click);
            // 
            // buttonAirport
            // 
            this.buttonAirport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAirport.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAirport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonAirport.Location = new System.Drawing.Point(12, 134);
            this.buttonAirport.Name = "buttonAirport";
            this.buttonAirport.Size = new System.Drawing.Size(171, 97);
            this.buttonAirport.TabIndex = 64;
            this.buttonAirport.Text = "Аэропорт";
            this.buttonAirport.UseVisualStyleBackColor = true;
            this.buttonAirport.Click += new System.EventHandler(this.buttonAirport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label2.Location = new System.Drawing.Point(455, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информационное табло";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(476, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Airline System";
            // 
            // viewGrid
            // 
            this.viewGrid.AllowUserToAddRows = false;
            this.viewGrid.AllowUserToDeleteRows = false;
            this.viewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Airport_ID,
            this.Airport_Name,
            this.City,
            this.Counrty,
            this.Status,
            this.IDd,
            this.Arrival,
            this.Depart,
            this.а,
            this.f,
            this.pay});
            this.viewGrid.Location = new System.Drawing.Point(169, 276);
            this.viewGrid.Name = "viewGrid";
            this.viewGrid.ReadOnly = true;
            this.viewGrid.RowHeadersWidth = 51;
            this.viewGrid.RowTemplate.Height = 24;
            this.viewGrid.Size = new System.Drawing.Size(1014, 349);
            this.viewGrid.TabIndex = 64;
            // 
<<<<<<< HEAD
            // Airport_ID
            // 
            this.Airport_ID.HeaderText = "Аэропорт ID";
            this.Airport_ID.MinimumWidth = 6;
            this.Airport_ID.Name = "Airport_ID";
            this.Airport_ID.ReadOnly = true;
            this.Airport_ID.Width = 125;
            // 
            // Airport_Name
            // 
            this.Airport_Name.HeaderText = "Название аэропорта";
            this.Airport_Name.MinimumWidth = 6;
            this.Airport_Name.Name = "Airport_Name";
            this.Airport_Name.ReadOnly = true;
            this.Airport_Name.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Counrty
            // 
            this.Counrty.HeaderText = "Страна";
            this.Counrty.MinimumWidth = 6;
            this.Counrty.Name = "Counrty";
            this.Counrty.ReadOnly = true;
            this.Counrty.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // IDd
            // 
            this.IDd.HeaderText = "ID";
            this.IDd.MinimumWidth = 6;
            this.IDd.Name = "IDd";
            this.IDd.ReadOnly = true;
            this.IDd.Width = 125;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Прибытие";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 125;
            // 
            // Depart
            // 
            this.Depart.HeaderText = "Отправление";
            this.Depart.MinimumWidth = 6;
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            this.Depart.Width = 125;
            // 
            // а
            // 
            this.а.HeaderText = "f";
            this.а.MinimumWidth = 6;
            this.а.Name = "а";
            this.а.ReadOnly = true;
            this.а.Visible = false;
            this.а.Width = 125;
            // 
            // f
            // 
            this.f.HeaderText = "f";
            this.f.MinimumWidth = 6;
            this.f.Name = "f";
            this.f.ReadOnly = true;
            this.f.Visible = false;
            this.f.Width = 125;
            // 
            // pay
            // 
            this.pay.HeaderText = "Цена";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            this.pay.Width = 125;
            // 
=======
>>>>>>> 21729aab75e1fae98a5cce56a9dc10f8d8a7ffc5
            // selectAttribute
            // 
            this.selectAttribute.FormattingEnabled = true;
            this.selectAttribute.Location = new System.Drawing.Point(197, 227);
            this.selectAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAttribute.Name = "selectAttribute";
            this.selectAttribute.Size = new System.Drawing.Size(127, 24);
            this.selectAttribute.TabIndex = 70;
            // 
            // newValueBox
            // 
            this.newValueBox.Location = new System.Drawing.Point(758, 227);
            this.newValueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newValueBox.Name = "newValueBox";
            this.newValueBox.Size = new System.Drawing.Size(177, 22);
            this.newValueBox.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(547, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 26);
            this.label5.TabIndex = 68;
            this.label5.Text = "Новое значение";
            // 
            // deletePromptLabel
            // 
            this.deletePromptLabel.AutoSize = true;
            this.deletePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deletePromptLabel.ForeColor = System.Drawing.Color.White;
            this.deletePromptLabel.Location = new System.Drawing.Point(353, 225);
            this.deletePromptLabel.Name = "deletePromptLabel";
            this.deletePromptLabel.Size = new System.Drawing.Size(31, 25);
            this.deletePromptLabel.TabIndex = 65;
            this.deletePromptLabel.Text = "ID";
            // 
            // deleteIDTextBox
            // 
            this.deleteIDTextBox.Location = new System.Drawing.Point(402, 227);
            this.deleteIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteIDTextBox.Name = "deleteIDTextBox";
            this.deleteIDTextBox.Size = new System.Drawing.Size(130, 22);
            this.deleteIDTextBox.TabIndex = 66;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(327, 658);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 41);
            this.buttonAdd.TabIndex = 82;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEdit.Location = new System.Drawing.Point(552, 658);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(168, 41);
            this.buttonEdit.TabIndex = 83;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(784, 658);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(168, 41);
            this.buttonDelete.TabIndex = 84;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.tableNameHeader.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.tableNameHeader.Location = new System.Drawing.Point(540, 151);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(190, 32);
            this.tableNameHeader.TabIndex = 5;
            this.tableNameHeader.Text = "Airline System";
            // 
            // deleteButtonCon
            // 
            this.deleteButtonCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.deleteButtonCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButtonCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButtonCon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButtonCon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteButtonCon.Location = new System.Drawing.Point(969, 217);
            this.deleteButtonCon.Name = "deleteButtonCon";
            this.deleteButtonCon.Size = new System.Drawing.Size(168, 41);
            this.deleteButtonCon.TabIndex = 85;
            this.deleteButtonCon.Text = "Удалить";
            this.deleteButtonCon.UseVisualStyleBackColor = false;
            this.deleteButtonCon.Click += new System.EventHandler(this.deleteButtonCon_Click);
            // 
            // Airport_ID
            // 
            this.Airport_ID.HeaderText = "Аэропорт ID";
            this.Airport_ID.MinimumWidth = 6;
            this.Airport_ID.Name = "Airport_ID";
            this.Airport_ID.ReadOnly = true;
            this.Airport_ID.Width = 125;
            // 
            // Airport_Name
            // 
            this.Airport_Name.HeaderText = "Название аэропорта";
            this.Airport_Name.MinimumWidth = 6;
            this.Airport_Name.Name = "Airport_Name";
            this.Airport_Name.ReadOnly = true;
            this.Airport_Name.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Counrty
            // 
            this.Counrty.HeaderText = "Страна";
            this.Counrty.MinimumWidth = 6;
            this.Counrty.Name = "Counrty";
            this.Counrty.ReadOnly = true;
            this.Counrty.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // IDd
            // 
            this.IDd.HeaderText = "ID";
            this.IDd.MinimumWidth = 6;
            this.IDd.Name = "IDd";
            this.IDd.ReadOnly = true;
            this.IDd.Width = 125;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Прибытие";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 125;
            // 
            // Depart
            // 
            this.Depart.HeaderText = "Отправление";
            this.Depart.MinimumWidth = 6;
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            this.Depart.Width = 125;
            // 
            // а
            // 
            this.а.HeaderText = "f";
            this.а.MinimumWidth = 6;
            this.а.Name = "а";
            this.а.ReadOnly = true;
            this.а.Visible = false;
            this.а.Width = 125;
            // 
            // f
            // 
            this.f.HeaderText = "f";
            this.f.MinimumWidth = 6;
            this.f.Name = "f";
            this.f.ReadOnly = true;
            this.f.Visible = false;
            this.f.Width = 125;
            // 
            // pay
            // 
            this.pay.HeaderText = "Цена";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            this.pay.Width = 125;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1183, 730);
            this.Controls.Add(this.deleteButtonCon);
            this.Controls.Add(this.tableNameHeader);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.selectAttribute);
            this.Controls.Add(this.newValueBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletePromptLabel);
            this.Controls.Add(this.deleteIDTextBox);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFlight;
        private System.Windows.Forms.Button buttonAirplane;
        private System.Windows.Forms.Button buttonAirport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.Button buttonAirline;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.ComboBox selectAttribute;
        private System.Windows.Forms.TextBox newValueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deletePromptLabel;
        private System.Windows.Forms.TextBox deleteIDTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Button deleteButtonCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airport_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airport_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counrty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn а;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
    }
}