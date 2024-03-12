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
        DBEmployeesDataContext dc = new DBEmployeesDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = from emp in dc.employees
                       select emp;
            listBox1.DataSource = data;
            
            var data2 = from emp in dc.employees
                        where emp.employee_id == 110
                        select emp;

            var data3 = from emp in dc.employees
                        where emp.employee_id == 110
                        select emp;
            employees e1 = data3.FirstOrDefault();
            MessageBox.Show(e1.first_name);  
                }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            employees e2 = (employees)listBox1.SelectedItem;
            e2.first_name = "*" + e2.first_name;

            dc.SubmitChanges();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            employees e3 = new employees()
            {
                first_name = "Apelo",
                last_name = "Pepito",
                email = "ss@dd.es",
                job_id = 1,
                salary = 10000,
                hire_date = DateTime.Now
            };

            dc.employees.InsertOnSubmit(e3);
            dc.SubmitChanges();
            }
        }
    

    public partial class employees
    {
        public override string ToString()
        {
            return first_name + ' ' + last_name;
        }
    }
}
