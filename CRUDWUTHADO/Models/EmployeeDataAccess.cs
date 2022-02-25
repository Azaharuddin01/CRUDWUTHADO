using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CRUDWUTHADO.Models
{
    public class EmployeeDataAccess
    {
        DBConnection dbconnection;
        public EmployeeDataAccess()
        {
            dbconnection = new DBConnection();
        }

        public List<Employees> GetEmployees()
        {
            
            {
                string Sp = "Sp_EMPLOYEE";
                SqlCommand sql = new SqlCommand(Sp, dbconnection.Connection);
                if (dbconnection.Connection.State == ConnectionState.Closed)
                {
                    dbconnection.Connection.Open();
                }

                SqlDataReader dr = sql.ExecuteReader();
                List<Employees> employees = new List<Employees>();
                while (dr.Read())
                {
                    Employees Emp = new Employees();
                    Emp.Id = (int)dr["id"];
                    Emp.Name = dr["name"].ToString();
                    Emp.Name = dr["name"].ToString();
                    Emp.Name = dr["name"].ToString();
                    Emp.Name = dr["name"].ToString();

                }
            }
        }
    }
}
