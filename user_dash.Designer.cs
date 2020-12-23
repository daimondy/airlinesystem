namespace airlinesystem
{
    partial class user_dash
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAirline = new System.Windows.Forms.Button();
            this.buttonAirport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGrid = new System.Windows.Forms.DataGridView();
            this.Airport_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airport_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counrty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelExit);
            this.panel2.Controls.Add(this.label1);
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
            this.panel1.Controls.Add(this.buttonAirline);
            this.panel1.Controls.Add(this.buttonAirport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 736);
            this.panel1.TabIndex = 63;
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
            this.buttonAirline.Text = "Купить билет";
            this.buttonAirline.UseVisualStyleBackColor = true;
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
            this.buttonAirport.Text = "Заполнить данные";
            this.buttonAirport.UseVisualStyleBackColor = true;
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
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.tableNameHeader.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.tableNameHeader.Location = new System.Drawing.Point(520, 161);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(190, 32);
            this.tableNameHeader.TabIndex = 5;
            this.tableNameHeader.Text = "Airline System";
            // 
            // viewGrid
            // 
            this.viewGrid.AllowUserToAddRows = false;
            this.viewGrid.AllowUserToDeleteRows = false;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Airport_ID,
            this.Airport_Name,
            this.City,
            this.Counrty,
            this.IDd,
            this.Arrival,
            this.Depart});
            this.viewGrid.Location = new System.Drawing.Point(191, 250);
            this.viewGrid.Name = "viewGrid";
            this.viewGrid.ReadOnly = true;
            this.viewGrid.RowHeadersWidth = 51;
            this.viewGrid.RowTemplate.Height = 24;
            this.viewGrid.Size = new System.Drawing.Size(949, 349);
            this.viewGrid.TabIndex = 65;
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
            // user_dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1183, 730);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.tableNameHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user_dash";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAirport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Button buttonAirline;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airport_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airport_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counrty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
    }
}