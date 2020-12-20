namespace airlinesystem
{
    partial class airline
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonAirplane = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAirport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID_A = new System.Windows.Forms.TextBox();
            this.textBoxName_A = new System.Windows.Forms.TextBox();
            this.textBoxCount_A = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 100);
            this.panel3.TabIndex = 2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label7.Location = new System.Drawing.Point(488, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Добавление авиакомпании";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-12, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 137);
            this.panel2.TabIndex = 65;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.buttonFlight);
            this.panel1.Controls.Add(this.buttonAirplane);
            this.panel1.Controls.Add(this.buttonAirport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-12, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 647);
            this.panel1.TabIndex = 66;
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
            // buttonDashboard
            // 
            this.buttonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonDashboard.Location = new System.Drawing.Point(6, 502);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(183, 91);
            this.buttonDashboard.TabIndex = 67;
            this.buttonDashboard.Text = "Информационное\r\nтабло";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label5.Location = new System.Drawing.Point(372, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "ID Авиакомпании";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label6.Location = new System.Drawing.Point(372, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "Количество самолетов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.label8.Location = new System.Drawing.Point(372, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Имя авиакомпании";
            // 
            // textBoxID_A
            // 
            this.textBoxID_A.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID_A.Location = new System.Drawing.Point(636, 241);
            this.textBoxID_A.Multiline = true;
            this.textBoxID_A.Name = "textBoxID_A";
            this.textBoxID_A.Size = new System.Drawing.Size(256, 32);
            this.textBoxID_A.TabIndex = 73;
            this.textBoxID_A.UseSystemPasswordChar = true;
            // 
            // textBoxName_A
            // 
            this.textBoxName_A.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_A.Location = new System.Drawing.Point(636, 324);
            this.textBoxName_A.Multiline = true;
            this.textBoxName_A.Name = "textBoxName_A";
            this.textBoxName_A.Size = new System.Drawing.Size(256, 32);
            this.textBoxName_A.TabIndex = 74;
            this.textBoxName_A.UseSystemPasswordChar = true;
            // 
            // textBoxCount_A
            // 
            this.textBoxCount_A.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount_A.Location = new System.Drawing.Point(636, 397);
            this.textBoxCount_A.Multiline = true;
            this.textBoxCount_A.Name = "textBoxCount_A";
            this.textBoxCount_A.Size = new System.Drawing.Size(256, 32);
            this.textBoxCount_A.TabIndex = 75;
            this.textBoxCount_A.UseSystemPasswordChar = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(541, 519);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(168, 41);
            this.buttonSave.TabIndex = 81;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(695, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 19);
            this.label9.TabIndex = 82;
            this.label9.Text = "*Только число*";
            // 
            // airline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1151, 643);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCount_A);
            this.Controls.Add(this.textBoxName_A);
            this.Controls.Add(this.textBoxID_A);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "airline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "airline";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonFlight;
        private System.Windows.Forms.Button buttonAirplane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAirport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxID_A;
        private System.Windows.Forms.TextBox textBoxName_A;
        private System.Windows.Forms.TextBox textBoxCount_A;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label9;
    }
}