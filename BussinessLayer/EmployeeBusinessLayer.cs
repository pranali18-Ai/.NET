using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BussinessLayer;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            get
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.ID = Convert.ToInt32(rdr["Id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.Gender = rdr["Gender"].ToString();
                        employee.City = rdr["City"].ToString();
                        employee.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);

                        employees.Add(employee);
                    }
                }

                return employees;
            }
        }
    }
}