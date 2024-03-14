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
    public partial class Form1 : Form
    {
        //DBEmployeesDataContext dc = new DBEmployeesDataContext();
            DALEmployee dALEmployee = new DALEmployee();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBoxEmployee.DataSource = dALEmployee.Select(); //DataSource es el contenido que tiene el comboBox
            DALDepartment dALDepartment = new DALDepartment();
            DALJob dALJob = new DALJob();
            
            comboBoxDepartment.DataSource = dALDepartment.Select(); 
            comboBoxJob.DataSource = dALJob.Select();
            comboBoxManager.DataSource = dALEmployee.Select();

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
            employees e2 = (employees)listBoxEmployee.SelectedItem;
   
            dALEmployee.Update();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            jobs job = new jobs();
            departments department = new departments();
            employees manager = new employees();

            job = comboBoxJob.SelectedItem as jobs; //el objeto seleccionado del comboBox es un job, cogemos el objeto seleccionado y lo pasamos a un objeto jobs 
            department = comboBoxDepartment.SelectedItem as departments;
            manager = comboBoxManager.SelectedItem as employees;

            employees e3 = new employees()
            {
                first_name = textBoxFirst_name.Text,
                last_name = textBoxLast_name.Text,
                email = textBoxEmail.Text,
                phone_number = textBoxPhone_number.Text,
                hire_date = dateTimeHire_date.Value,
                salary = numericUpDownSalary.Value,
                manager_id = manager.employee_id,
                department_id = department.department_id,
                job_id = job.job_id
            };
            dALEmployee.Insertar(e3); 
            //Pasamos el objeto que hemos creado y lo ponemos en la base de datos

            }

        private void butDelete_Click(object sender, EventArgs e)
        {
            //DALEmployee dALEmployee = new DALEmployee();
            dALEmployee.Delete((employees)listBoxEmployee.SelectedItem);
        }
    }


    public partial class employees
    {

    }
}
