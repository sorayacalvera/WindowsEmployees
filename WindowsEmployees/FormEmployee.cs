using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsEmployees
{
    public partial class FormEmployee : Form
    {
        DALDepartment dALDepartment = new DALDepartment();
        DALJob dALJob = new DALJob();
        DALEmployee dALEmployee = new DALEmployee();

        private employees employee;

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDepartment.DataSource = dALDepartment.Select();
            comboBoxDepartment.DisplayMember = "department_name";
            comboBoxDepartment.ValueMember = "department_id";

            comboBoxJob.DataSource = dALJob.Select();
            comboBoxJob.DisplayMember = "job_tittle";
            comboBoxJob.ValueMember = "job_id";

            comboBoxManager.DataSource = dALEmployee.Select();
            comboBoxManager.DisplayMember = "first_name";
            comboBoxManager.ValueMember = "employee_id";

            /*            
                        var data2 = from emp in dc.employees
                                    where emp.employee_id == 110
                                    select emp;

                        var data3 = from emp in dc.employees
                                    where emp.employee_id == 110
                                    select emp;
                        employees e1 = data3.FirstOrDefault();
                        MessageBox.Show(e1.first_name);  */
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            employee = (employees)listBoxEmployee.SelectedItem;

            textBoxFirst_name.Text = employee.first_name;
            textBoxLast_name.Text = employee.last_name;
            textBoxEmail.Text = employee.email;
            textBoxPhone_number.Text = employee.phone_number;
            dateTimeHire_date.Value = employee.hire_date;
            numericUpDownSalary.Value = employee.salary;
            // ?? significa que si es nulo lo ponga en 0
            comboBoxManager.SelectedValue = employee.manager_id ?? 0;
            comboBoxDepartment.SelectedValue = employee.department_id ?? 0;
            comboBoxJob.SelectedValue = employee.job_id;
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            //el objeto seleccionado del comboBox es un job, cogemos el objeto seleccionado
            //y lo pasamos a un objeto jobs
            jobs job = comboBoxJob.SelectedItem as jobs;
            departments department = comboBoxDepartment.SelectedItem as departments;
            employees manager = comboBoxManager.SelectedItem as employees;

            employees e3 = new employees()
            {
                first_name = textBoxFirst_name.Text,
                last_name = textBoxLast_name.Text,
                email = textBoxEmail.Text,
                phone_number = textBoxPhone_number.Text,
                hire_date = dateTimeHire_date.Value,
                salary = numericUpDownSalary.Value,
                manager_id = manager == null ? (int?)null : manager.employee_id,
                department_id = department == null ? (int?)null : department.department_id,
                job_id = job.job_id
            };
            dALEmployee.Insertar(e3);
            //Pasamos el objeto que hemos creado y lo ponemos en la base de datos
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            dALEmployee.Delete((employees)listBoxEmployee.SelectedItem);

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            listBoxEmployee.DataSource = dALEmployee.Select();
        }


        private void butModificar_Click(object sender, EventArgs e)
        {
            employee.first_name = textBoxFirst_name.Text;
            employee.last_name = textBoxLast_name.Text;
            employee.email = textBoxEmail.Text;
            employee.phone_number = textBoxPhone_number.Text;
            employee.hire_date = dateTimeHire_date.Value;
            employee.salary = numericUpDownSalary.Value;
            employee.manager_id = (int?)comboBoxManager.SelectedValue ?? 0;
            employee.department_id = (int?)comboBoxDepartment.SelectedValue ?? 0;
            employee.job_id = (int)comboBoxJob.SelectedValue;

            dALEmployee.Update();
        }
    }


    public partial class employees
    {

    }
}
