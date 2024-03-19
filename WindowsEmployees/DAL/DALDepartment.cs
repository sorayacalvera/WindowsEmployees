using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmployees
{
    internal class DALDepartment
    {
        DBEmployeesDataContext dc = new DBEmployeesDataContext();
        public IQueryable Select()
        {
            var data = from dep in dc.departments
                       select dep;
            return data;
        }

        public IQueryable SelectByIdDepartment(int idDepartment) //IQueriable tipo de variable que devuelve LINQ
        {
            var data = from dep in dc.departments
                       where dep.department_id == idDepartment
                       select dep;
            return data;

        }
    }
}
