namespace CompanySystem.Forms
{
    partial class MainForm
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
            this.LblNameDepartment = new System.Windows.Forms.Label();
            this.LblDepartmentCode = new System.Windows.Forms.Label();
            this.DtGdVwAssignments = new System.Windows.Forms.DataGridView();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAssignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblIDEmployee = new System.Windows.Forms.Label();
            this.LblLastNameEmployee = new System.Windows.Forms.Label();
            this.LblNameEmployee = new System.Windows.Forms.Label();
            this.TxtNameEmployee = new System.Windows.Forms.TextBox();
            this.TxtNameDepartment = new System.Windows.Forms.TextBox();
            this.TxtLastNameEmployee = new System.Windows.Forms.TextBox();
            this.TxtIDEmployee = new System.Windows.Forms.TextBox();
            this.TxtDepartmentCode = new System.Windows.Forms.TextBox();
            this.BtnAddAsgnacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNameDepartment
            // 
            this.LblNameDepartment.AutoSize = true;
            this.LblNameDepartment.Location = new System.Drawing.Point(937, 455);
            this.LblNameDepartment.Name = "LblNameDepartment";
            this.LblNameDepartment.Size = new System.Drawing.Size(117, 16);
            this.LblNameDepartment.TabIndex = 9;
            this.LblNameDepartment.Text = "Name Department";
            // 
            // LblDepartmentCode
            // 
            this.LblDepartmentCode.AutoSize = true;
            this.LblDepartmentCode.Location = new System.Drawing.Point(1151, 455);
            this.LblDepartmentCode.Name = "LblDepartmentCode";
            this.LblDepartmentCode.Size = new System.Drawing.Size(113, 16);
            this.LblDepartmentCode.TabIndex = 10;
            this.LblDepartmentCode.Text = "Department Code";
            // 
            // DtGdVwAssignments
            // 
            this.DtGdVwAssignments.AllowUserToOrderColumns = true;
            this.DtGdVwAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGdVwAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameEmployee,
            this.LastNameEmployee,
            this.IDEmployee,
            this.NameDepartment,
            this.DepartmentCode,
            this.DateAssignment});
            this.DtGdVwAssignments.Location = new System.Drawing.Point(498, 35);
            this.DtGdVwAssignments.Name = "DtGdVwAssignments";
            this.DtGdVwAssignments.RowHeadersWidth = 51;
            this.DtGdVwAssignments.RowTemplate.Height = 24;
            this.DtGdVwAssignments.Size = new System.Drawing.Size(805, 346);
            this.DtGdVwAssignments.TabIndex = 11;
            // 
            // NameEmployee
            // 
            this.NameEmployee.Frozen = true;
            this.NameEmployee.HeaderText = "Name Employee";
            this.NameEmployee.MinimumWidth = 6;
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.Width = 125;
            // 
            // LastNameEmployee
            // 
            this.LastNameEmployee.Frozen = true;
            this.LastNameEmployee.HeaderText = "Last Name Employee";
            this.LastNameEmployee.MinimumWidth = 6;
            this.LastNameEmployee.Name = "LastNameEmployee";
            this.LastNameEmployee.Width = 125;
            // 
            // IDEmployee
            // 
            this.IDEmployee.Frozen = true;
            this.IDEmployee.HeaderText = "ID Employee";
            this.IDEmployee.MinimumWidth = 6;
            this.IDEmployee.Name = "IDEmployee";
            this.IDEmployee.Width = 125;
            // 
            // NameDepartment
            // 
            this.NameDepartment.Frozen = true;
            this.NameDepartment.HeaderText = "Name Department";
            this.NameDepartment.MinimumWidth = 6;
            this.NameDepartment.Name = "NameDepartment";
            this.NameDepartment.Width = 125;
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.Frozen = true;
            this.DepartmentCode.HeaderText = "Department Code";
            this.DepartmentCode.MinimumWidth = 6;
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.Width = 125;
            // 
            // DateAssignment
            // 
            this.DateAssignment.Frozen = true;
            this.DateAssignment.HeaderText = "Date Assignment";
            this.DateAssignment.MinimumWidth = 6;
            this.DateAssignment.Name = "DateAssignment";
            this.DateAssignment.Width = 125;
            // 
            // LblIDEmployee
            // 
            this.LblIDEmployee.AutoSize = true;
            this.LblIDEmployee.Location = new System.Drawing.Point(756, 455);
            this.LblIDEmployee.Name = "LblIDEmployee";
            this.LblIDEmployee.Size = new System.Drawing.Size(85, 16);
            this.LblIDEmployee.TabIndex = 8;
            this.LblIDEmployee.Text = "ID Employee";
            // 
            // LblLastNameEmployee
            // 
            this.LblLastNameEmployee.AutoSize = true;
            this.LblLastNameEmployee.Location = new System.Drawing.Point(536, 455);
            this.LblLastNameEmployee.Name = "LblLastNameEmployee";
            this.LblLastNameEmployee.Size = new System.Drawing.Size(137, 16);
            this.LblLastNameEmployee.TabIndex = 7;
            this.LblLastNameEmployee.Text = "Last Name Employee";
            // 
            // LblNameEmployee
            // 
            this.LblNameEmployee.AutoSize = true;
            this.LblNameEmployee.Location = new System.Drawing.Point(351, 455);
            this.LblNameEmployee.Name = "LblNameEmployee";
            this.LblNameEmployee.Size = new System.Drawing.Size(109, 16);
            this.LblNameEmployee.TabIndex = 6;
            this.LblNameEmployee.Text = "Name Employee";
            // 
            // TxtNameEmployee
            // 
            this.TxtNameEmployee.Location = new System.Drawing.Point(129, 83);
            this.TxtNameEmployee.Name = "TxtNameEmployee";
            this.TxtNameEmployee.Size = new System.Drawing.Size(100, 22);
            this.TxtNameEmployee.TabIndex = 12;
            // 
            // TxtNameDepartment
            // 
            this.TxtNameDepartment.Location = new System.Drawing.Point(129, 325);
            this.TxtNameDepartment.Name = "TxtNameDepartment";
            this.TxtNameDepartment.Size = new System.Drawing.Size(100, 22);
            this.TxtNameDepartment.TabIndex = 13;
            // 
            // TxtLastNameEmployee
            // 
            this.TxtLastNameEmployee.Location = new System.Drawing.Point(129, 157);
            this.TxtLastNameEmployee.Name = "TxtLastNameEmployee";
            this.TxtLastNameEmployee.Size = new System.Drawing.Size(100, 22);
            this.TxtLastNameEmployee.TabIndex = 14;
            // 
            // TxtIDEmployee
            // 
            this.TxtIDEmployee.Location = new System.Drawing.Point(129, 222);
            this.TxtIDEmployee.Name = "TxtIDEmployee";
            this.TxtIDEmployee.Size = new System.Drawing.Size(100, 22);
            this.TxtIDEmployee.TabIndex = 15;
            // 
            // TxtDepartmentCode
            // 
            this.TxtDepartmentCode.Location = new System.Drawing.Point(129, 389);
            this.TxtDepartmentCode.Name = "TxtDepartmentCode";
            this.TxtDepartmentCode.Size = new System.Drawing.Size(100, 22);
            this.TxtDepartmentCode.TabIndex = 16;
            // 
            // BtnAddAsgnacion
            // 
            this.BtnAddAsgnacion.Location = new System.Drawing.Point(291, 196);
            this.BtnAddAsgnacion.Name = "BtnAddAsgnacion";
            this.BtnAddAsgnacion.Size = new System.Drawing.Size(98, 48);
            this.BtnAddAsgnacion.TabIndex = 17;
            this.BtnAddAsgnacion.Text = "Add Asgnacion";
            this.BtnAddAsgnacion.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 499);
            this.Controls.Add(this.BtnAddAsgnacion);
            this.Controls.Add(this.TxtDepartmentCode);
            this.Controls.Add(this.TxtIDEmployee);
            this.Controls.Add(this.TxtLastNameEmployee);
            this.Controls.Add(this.TxtNameDepartment);
            this.Controls.Add(this.TxtNameEmployee);
            this.Controls.Add(this.DtGdVwAssignments);
            this.Controls.Add(this.LblDepartmentCode);
            this.Controls.Add(this.LblNameDepartment);
            this.Controls.Add(this.LblIDEmployee);
            this.Controls.Add(this.LblLastNameEmployee);
            this.Controls.Add(this.LblNameEmployee);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNameDepartment;
        private System.Windows.Forms.Label LblDepartmentCode;
        private System.Windows.Forms.DataGridView DtGdVwAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAssignment;
        private System.Windows.Forms.Label LblIDEmployee;
        private System.Windows.Forms.Label LblLastNameEmployee;
        private System.Windows.Forms.Label LblNameEmployee;
        private System.Windows.Forms.TextBox TxtNameEmployee;
        private System.Windows.Forms.TextBox TxtNameDepartment;
        private System.Windows.Forms.TextBox TxtLastNameEmployee;
        private System.Windows.Forms.TextBox TxtIDEmployee;
        private System.Windows.Forms.TextBox TxtDepartmentCode;
        private System.Windows.Forms.Button BtnAddAsgnacion;
    }
}