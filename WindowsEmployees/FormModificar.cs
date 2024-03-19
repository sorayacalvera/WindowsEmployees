using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEmployees
{
    public partial class FormModificar : Form
    {

        DALDepartment dALDepartment = new DALDepartment();
        DALJob dALJob = new DALJob();
        DALEmployee dALEmployee = new DALEmployee();

        private employees employee;
        public FormModificar(employees employees)
        {
            InitializeComponent();
            employee = employees;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            employee.first_name = textBoxFirst_nameModif.Text;
            employee.last_name = textBoxLast_nameModif.Text;
            employee.email = textBoxEmailModif.Text;
            employee.phone_number = textBoxPhone_numberModif.Text;
            employee.hire_date = dateTimeHire_dateModif.Value;
            employee.salary = numericUpDownSalaryModif.Value;
            employee.manager_id = (int?)comboBoxManagerModif.SelectedValue ?? 0;
            employee.department_id = (int?)comboBoxDepartmentModif.SelectedValue ?? 0;
            employee.job_id = (int)comboBoxJobModif.SelectedValue;

            dALEmployee.Update();
            Close();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            comboBoxDepartmentModif.DataSource = dALDepartment.Select();
            comboBoxDepartmentModif.DisplayMember = "department_name";
            comboBoxDepartmentModif.ValueMember = "department_id";

            comboBoxJobModif.DataSource = dALJob.Select();
            comboBoxJobModif.DisplayMember = "job_title";
            comboBoxJobModif.ValueMember = "job_id";

            comboBoxManagerModif.DataSource = dALEmployee.Select();
            comboBoxManagerModif.DisplayMember = "first_name";
            comboBoxManagerModif.ValueMember = "employee_id";

            textBoxFirst_nameModif.Text = employee.first_name;
            textBoxLast_nameModif.Text = employee.last_name;
            textBoxEmailModif.Text = employee.email;
            textBoxPhone_numberModif.Text = employee.phone_number;
            dateTimeHire_dateModif.Value = employee.hire_date;
            numericUpDownSalaryModif.Value = employee.salary;
            // ?? significa que si es nulo lo ponga en 0
            comboBoxManagerModif.SelectedValue = employee.manager_id ?? 0;
            comboBoxDepartmentModif.SelectedValue = employee.department_id ?? 0;
            comboBoxJobModif.SelectedValue = employee.job_id;
        }


    }
}
