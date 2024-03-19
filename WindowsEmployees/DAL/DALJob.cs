using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmployees
{
    internal class DALJob
    {
        DBEmployeesDataContext dc = new DBEmployeesDataContext();
        public IQueryable Select() //Mostrar lista de trabajos
        {
            var data = from job in dc.jobs
                       select job;
            return data;
        }

        public IQueryable SelectByIdJob(int idJob) //IQueriable tipo de variable que devuelve LINQ
        {
            var data = from job in dc.jobs
                       where job.job_id == idJob
                       select job;
            return data;
                      
        }
    }
}
