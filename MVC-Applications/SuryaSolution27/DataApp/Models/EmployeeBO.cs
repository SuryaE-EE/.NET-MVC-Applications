namespace DataApp.Models
{
    public class EmployeeBO
    {
        EmployeeHelper helper = new EmployeeHelper();
        public List<EmployeeModel> GetAllEmployees()
        {
            
            return helper.GetAll();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return helper.GetById(id);
        }

        public int AddEmployee(EmployeeModel e)
        {
            return helper.AddEmployee(e);
        }

        public int EditEmployeeById(int id, EmployeeModel e)
        {
            return helper.EditEmployee(e, id);
        }

        public int DeleteEmployeeById(int id)
        {
            return helper.DeleteEmployee(id);
        }
    }
}