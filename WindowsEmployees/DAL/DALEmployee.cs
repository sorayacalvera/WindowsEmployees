using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmployees
{
    internal class DALEmployee
    {
        //update sirve para cambiar datos dentro de una tabla 
        //delete para eliminar filas en una tabla
        //insert para insertar filas
        //select para mostrar las filas que yo quiero 

        DBEmployeesDataContext dc = new DBEmployeesDataContext();
        public IQueryable Select() //Sirve para mostrar la lista de empleados
        {
            var data = from emp in dc.employees
                       select emp;
            return data;
        }

        public void Update()
        {
            dc.SubmitChanges();
        }
        public void Insertar(employees empl)
        {
            dc.employees.InsertOnSubmit(empl);
            dc.SubmitChanges();
        }

        public void Delete(employees empl)
        {
            dc.employees.DeleteOnSubmit(empl);
            dc.SubmitChanges();
        }
    }
}
