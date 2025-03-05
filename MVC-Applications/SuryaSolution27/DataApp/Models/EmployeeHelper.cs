using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting.Server;

namespace DataApp.Models
{
    public class EmployeeHelper
    {
        private List<EmployeeModel> employees;

        public SqlConnection ConnectToSql()
        {

            string cs = "server=DESKTOP-FHBRPJ7;database=Surya;Integrated Security = True";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }

        public List<EmployeeModel> GetAll()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("select * from tb1Employees", ConnectToSql());
            SqlDataReader dr = cmd.ExecuteReader();
            EmployeeModel e;
            while (dr.Read())
            {
                e = new EmployeeModel();
                e.Id = Convert.ToInt32(dr[0]);
                e.EName = dr[1].ToString();
                e.Job = dr[2].ToString();
                e.Salary = Convert.ToInt32(dr[3]);
                employees.Add(e);
            }

            return employees; ;
        }

        public EmployeeModel GetById(int id)
        {
            
            SqlCommand cmd = new SqlCommand("select * from tb1Employees where id=@id", ConnectToSql());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            EmployeeModel e = new EmployeeModel();
            if (dr.Read())
            {
                e.Id = Convert.ToInt32(dr[0]);
                e.EName = dr[1].ToString();
                e.Job = dr[2].ToString();
                e.Salary = Convert.ToInt32(dr[3]);
                
            }

            return e;

        }
        public int ExecuteNonQuery(string query)
        {
            SqlCommand cmd =new SqlCommand(query, ConnectToSql());
            return cmd.ExecuteNonQuery();
        }

        public int AddEmployee(EmployeeModel e)
        {
            string query = $"insert into tb1Employees values ({e.Id}, '{e.EName}', '{e.Job}', {e.Salary})";
            return ExecuteNonQuery(query);

        }

        public int EditEmployee(EmployeeModel e, int id)
        {
            string query = $"update into tb1Employees set ename '{e.EName}', job = '{e.Job}', salary = {e.Salary})";
            return ExecuteNonQuery(query);
        }

        public int DeleteEmployee(int id)
        {
            string query = $"delete tb1Employees where id={id})";
            return ExecuteNonQuery(query);
        }


    }
}
