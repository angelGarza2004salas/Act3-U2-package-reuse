using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanySystem.Forms
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using CompanySystem.Models;
    using CompanySystem.Services;
    public partial class MainForm : Form
    {
        private ServiceAssignment serviceAssignment = new ServiceAssignment();
        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadDataGrid();
        }
        private void InitializeCustomComponents()
        {
            //Create and configure TextBoxes
            TextBox TxtNameEmployee = new TextBox { Name = "TxtNameEmployee"};
            TextBox TxtLastNameEmployee = new TextBox { Name = "TxtLastNameEmployee"};
            TextBox txtIDEmployee = new TextBox { Name = "txtIDEmployee"};
            TextBox TxtNameDepartment = new TextBox { Name = "TxtNameDepartment"};
            TextBox TxtDepartmentCode = new TextBox { Name = "TxtDepartmentCode"};


            //Create and configure Button
            Button BtnAddAsgnacion = new Button { Name = "BtnAddAsgnacion", Text = "Add Asignture" };
            BtnAddAsgnacion.Click += new EventHandler(BtnAddAsgnacion_Click);


            //Create and configure DataGridView
            DataGridView dtGdVwAssignments = new DataGridView { Name = "dtGdVwAssignments"};
            dtGdVwAssignments.Columns.Add("NameEmployee", "Name Employee");
            dtGdVwAssignments.Columns.Add("LastNameEmployee", "Last Name Employee");
            dtGdVwAssignments.Columns.Add("IDEmployee", "ID Employee");
            dtGdVwAssignments.Columns.Add("NameDepartment", "Name Department");
            dtGdVwAssignments.Columns.Add("DepartmentCode", "Department Code");
            dtGdVwAssignments.Columns.Add("DateAssignment", "Date Assignment");


            //Add controls to the form
            this.Controls.Add(TxtNameEmployee);
            this.Controls.Add(TxtLastNameEmployee);
            this.Controls.Add(TxtIDEmployee);
            this.Controls.Add(TxtNameDepartment);
            this.Controls.Add(TxtDepartmentCode);
            this.Controls.Add(BtnAddAsgnacion);
            this.Controls.Add(DtGdVwAssignments);

        }


        private void BtnAddAsgnacion_Click(object sender, EventArgs e)
        {
            //validate that the compos are not empty
            if (string.IsNullOrWhiteSpace(TxtNameEmployee.Text)) 
            {
                MessageBox.Show("The employee's name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtLastNameEmployee.Text))
            {
                MessageBox.Show("The employee's last name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtIDEmployee.Text))
            {
                MessageBox.Show("The employee's ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtNameDepartment.Text))
            {
                MessageBox.Show("The department's name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtDepartmentCode.Text))
            {
                MessageBox.Show("The department's code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate that the ID is numeric - Validate the format of the employee's ID as email
            if (!Regex.IsMatch(TxtIDEmployee.Text, @"^[^@\s]+@[^@\s]\.[^@\s]+$"))
            {
                MessageBox.Show("The employee's ID must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create the objects employee and Department
            var employee = new Employee(TxtNameEmployee.Text, TxtLastNameEmployee.Text, TxtIDEmployee.Text);
            var department = new Department(TxtNameDepartment.Text, TxtDepartmentCode.Text);


            //Create the assignment object
            var assignment = new Assignment(employee, department, DateTime.Now);

            //Add the assignment to the service
            serviceAssignment.AddAssignment(assignment);


            //Show message excelent
            MessageBox.Show("Assignment successfully added!");

            //update DataGridView
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            //Obtain the DataGridView
            var dtGdVwAssignments = (DataGridView)this.Controls["dtGdVwAssignments"];
            if (dtGdVwAssignments != null)
            {
                dtGdVwAssignments.Rows.Clear();
                foreach (var assignment in serviceAssignment.ObtainAssignments())
                {
                    dtGdVwAssignments.Rows.Add(assignment.Employee.Nombre, assignment.Employee.Apellido, assignment.Employee.ID, assignment.Department.Nombre, assignment.Department.Codigo, assignment.DateAssignment);
                }
            }
        }

    }
}
