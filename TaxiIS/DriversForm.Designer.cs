namespace TaxiIS
{
    partial class DriversForm
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
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteDriver = new System.Windows.Forms.Button();
            this.buttonEditDriver = new System.Windows.Forms.Button();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.AllowUserToAddRows = false;
            this.dataGridViewDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverName,
            this.colCarModel,
            this.colLicensePlate});
            this.dataGridViewDrivers.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.ReadOnly = true;
            this.dataGridViewDrivers.RowHeadersWidth = 51;
            this.dataGridViewDrivers.RowTemplate.Height = 24;
            this.dataGridViewDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrivers.Size = new System.Drawing.Size(775, 223);
            this.dataGridViewDrivers.TabIndex = 0;
            this.dataGridViewDrivers.SelectionChanged += new System.EventHandler(this.dataGridViewDrivers_SelectionChanged_1);
            // 
            // colDriverName
            // 
            this.colDriverName.HeaderText = "ФИО водители";
            this.colDriverName.MinimumWidth = 6;
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.ReadOnly = true;
            // 
            // colCarModel
            // 
            this.colCarModel.HeaderText = "Марка авто";
            this.colCarModel.MinimumWidth = 6;
            this.colCarModel.Name = "colCarModel";
            this.colCarModel.ReadOnly = true;
            // 
            // colLicensePlate
            // 
            this.colLicensePlate.HeaderText = "Госномер";
            this.colLicensePlate.MinimumWidth = 6;
            this.colLicensePlate.Name = "colLicensePlate";
            this.colLicensePlate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление / Редактирование";
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Location = new System.Drawing.Point(411, 314);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(143, 22);
            this.textBoxCarModel.TabIndex = 25;
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(411, 283);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(143, 22);
            this.textBoxDriverName.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Марка авто";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "ФИО водителя";
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Location = new System.Drawing.Point(411, 345);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(143, 22);
            this.textBoxLicensePlate.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Госномер";
            // 
            // buttonDeleteDriver
            // 
            this.buttonDeleteDriver.Location = new System.Drawing.Point(570, 388);
            this.buttonDeleteDriver.Name = "buttonDeleteDriver";
            this.buttonDeleteDriver.Size = new System.Drawing.Size(173, 37);
            this.buttonDeleteDriver.TabIndex = 30;
            this.buttonDeleteDriver.Text = "Удалить водителя";
            this.buttonDeleteDriver.UseVisualStyleBackColor = true;
            this.buttonDeleteDriver.Click += new System.EventHandler(this.buttonDeleteDriver_Click);
            // 
            // buttonEditDriver
            // 
            this.buttonEditDriver.Location = new System.Drawing.Point(325, 388);
            this.buttonEditDriver.Name = "buttonEditDriver";
            this.buttonEditDriver.Size = new System.Drawing.Size(209, 37);
            this.buttonEditDriver.TabIndex = 29;
            this.buttonEditDriver.Text = "Редактировать водителя";
            this.buttonEditDriver.UseVisualStyleBackColor = true;
            this.buttonEditDriver.Click += new System.EventHandler(this.buttonEditDriver_Click);
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(116, 388);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(173, 37);
            this.buttonAddDriver.TabIndex = 28;
            this.buttonAddDriver.Text = "Добавить водителя";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteDriver);
            this.Controls.Add(this.buttonEditDriver);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCarModel);
            this.Controls.Add(this.textBoxDriverName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDrivers);
            this.Name = "DriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Водители";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicensePlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteDriver;
        private System.Windows.Forms.Button buttonEditDriver;
        private System.Windows.Forms.Button buttonAddDriver;
    }
}