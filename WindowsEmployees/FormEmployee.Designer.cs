namespace WindowsEmployees
{
    partial class FormEmployee
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.butInsert = new System.Windows.Forms.Button();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.dateTimeHire_date = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone_number = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLast_name = new System.Windows.Forms.TextBox();
            this.labDepartment_id = new System.Windows.Forms.Label();
            this.labJob_id = new System.Windows.Forms.Label();
            this.labManager_id = new System.Windows.Forms.Label();
            this.labSalary = new System.Windows.Forms.Label();
            this.labHire_date = new System.Windows.Forms.Label();
            this.labPhone_number = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labLast_name = new System.Windows.Forms.Label();
            this.textBoxFirst_name = new System.Windows.Forms.TextBox();
            this.labFirst_Name = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 16;
            this.listBoxEmployee.Location = new System.Drawing.Point(443, 46);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(345, 372);
            this.listBoxEmployee.TabIndex = 0;
            this.listBoxEmployee.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(334, 312);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(75, 23);
            this.butInsert.TabIndex = 1;
            this.butInsert.Text = "Insert";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Location = new System.Drawing.Point(164, 180);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(245, 22);
            this.numericUpDownSalary.TabIndex = 42;
            // 
            // dateTimeHire_date
            // 
            this.dateTimeHire_date.Location = new System.Drawing.Point(164, 151);
            this.dateTimeHire_date.Name = "dateTimeHire_date";
            this.dateTimeHire_date.Size = new System.Drawing.Size(244, 22);
            this.dateTimeHire_date.TabIndex = 39;
            // 
            // textBoxPhone_number
            // 
            this.textBoxPhone_number.Location = new System.Drawing.Point(163, 121);
            this.textBoxPhone_number.Name = "textBoxPhone_number";
            this.textBoxPhone_number.Size = new System.Drawing.Size(245, 22);
            this.textBoxPhone_number.TabIndex = 38;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(164, 93);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 22);
            this.textBoxEmail.TabIndex = 37;
            // 
            // textBoxLast_name
            // 
            this.textBoxLast_name.Location = new System.Drawing.Point(163, 63);
            this.textBoxLast_name.Name = "textBoxLast_name";
            this.textBoxLast_name.Size = new System.Drawing.Size(245, 22);
            this.textBoxLast_name.TabIndex = 36;
            // 
            // labDepartment_id
            // 
            this.labDepartment_id.AutoSize = true;
            this.labDepartment_id.Location = new System.Drawing.Point(45, 239);
            this.labDepartment_id.Name = "labDepartment_id";
            this.labDepartment_id.Size = new System.Drawing.Size(77, 16);
            this.labDepartment_id.TabIndex = 35;
            this.labDepartment_id.Text = "Department";
            // 
            // labJob_id
            // 
            this.labJob_id.AutoSize = true;
            this.labJob_id.Location = new System.Drawing.Point(45, 267);
            this.labJob_id.Name = "labJob_id";
            this.labJob_id.Size = new System.Drawing.Size(30, 16);
            this.labJob_id.TabIndex = 34;
            this.labJob_id.Text = "Job";
            // 
            // labManager_id
            // 
            this.labManager_id.AutoSize = true;
            this.labManager_id.Location = new System.Drawing.Point(45, 211);
            this.labManager_id.Name = "labManager_id";
            this.labManager_id.Size = new System.Drawing.Size(61, 16);
            this.labManager_id.TabIndex = 33;
            this.labManager_id.Text = "Manager";
            // 
            // labSalary
            // 
            this.labSalary.AutoSize = true;
            this.labSalary.Location = new System.Drawing.Point(45, 180);
            this.labSalary.Name = "labSalary";
            this.labSalary.Size = new System.Drawing.Size(46, 16);
            this.labSalary.TabIndex = 32;
            this.labSalary.Text = "Salary";
            // 
            // labHire_date
            // 
            this.labHire_date.AutoSize = true;
            this.labHire_date.Location = new System.Drawing.Point(45, 151);
            this.labHire_date.Name = "labHire_date";
            this.labHire_date.Size = new System.Drawing.Size(62, 16);
            this.labHire_date.TabIndex = 31;
            this.labHire_date.Text = "Hire date";
            // 
            // labPhone_number
            // 
            this.labPhone_number.AutoSize = true;
            this.labPhone_number.Location = new System.Drawing.Point(45, 124);
            this.labPhone_number.Name = "labPhone_number";
            this.labPhone_number.Size = new System.Drawing.Size(94, 16);
            this.labPhone_number.TabIndex = 30;
            this.labPhone_number.Text = "Phone number";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(45, 96);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(41, 16);
            this.labEmail.TabIndex = 29;
            this.labEmail.Text = "Email";
            // 
            // labLast_name
            // 
            this.labLast_name.AutoSize = true;
            this.labLast_name.Location = new System.Drawing.Point(45, 66);
            this.labLast_name.Name = "labLast_name";
            this.labLast_name.Size = new System.Drawing.Size(72, 16);
            this.labLast_name.TabIndex = 28;
            this.labLast_name.Text = "Last Name";
            // 
            // textBoxFirst_name
            // 
            this.textBoxFirst_name.Location = new System.Drawing.Point(164, 36);
            this.textBoxFirst_name.Name = "textBoxFirst_name";
            this.textBoxFirst_name.Size = new System.Drawing.Size(244, 22);
            this.textBoxFirst_name.TabIndex = 27;
            // 
            // labFirst_Name
            // 
            this.labFirst_Name.AutoSize = true;
            this.labFirst_Name.Location = new System.Drawing.Point(45, 36);
            this.labFirst_Name.Name = "labFirst_Name";
            this.labFirst_Name.Size = new System.Drawing.Size(72, 16);
            this.labFirst_Name.TabIndex = 26;
            this.labFirst_Name.Text = "First Name";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(163, 211);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(121, 24);
            this.comboBoxManager.TabIndex = 47;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(164, 239);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartment.TabIndex = 48;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Location = new System.Drawing.Point(163, 267);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(121, 24);
            this.comboBoxJob.TabIndex = 49;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(536, 439);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 51;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(443, 439);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 52;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(634, 439);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(75, 23);
            this.butRefresh.TabIndex = 53;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(238, 312);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(75, 23);
            this.butModificar.TabIndex = 54;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 499);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.comboBoxJob);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.dateTimeHire_date);
            this.Controls.Add(this.textBoxPhone_number);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLast_name);
            this.Controls.Add(this.labDepartment_id);
            this.Controls.Add(this.labJob_id);
            this.Controls.Add(this.labManager_id);
            this.Controls.Add(this.labSalary);
            this.Controls.Add(this.labHire_date);
            this.Controls.Add(this.labPhone_number);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labLast_name);
            this.Controls.Add(this.textBoxFirst_name);
            this.Controls.Add(this.labFirst_Name);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.listBoxEmployee);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.DateTimePicker dateTimeHire_date;
        private System.Windows.Forms.TextBox textBoxPhone_number;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLast_name;
        private System.Windows.Forms.Label labDepartment_id;
        private System.Windows.Forms.Label labJob_id;
        private System.Windows.Forms.Label labManager_id;
        private System.Windows.Forms.Label labSalary;
        private System.Windows.Forms.Label labHire_date;
        private System.Windows.Forms.Label labPhone_number;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labLast_name;
        private System.Windows.Forms.TextBox textBoxFirst_name;
        private System.Windows.Forms.Label labFirst_Name;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button butModificar;
    }
}

