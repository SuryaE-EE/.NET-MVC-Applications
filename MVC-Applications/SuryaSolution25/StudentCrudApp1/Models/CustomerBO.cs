using System.Drawing.Text;

namespace StudentCrudApp1.Models
{
    public class CustomerBO
    {
        private List<CustomerModel> Customers { get; set; }
        public CustomerBO()
        {
            Customers = new List<CustomerModel>();
            {
                new CustomerModel { Id = 1, CName = "Arvind", City = "Hyd", Email = "arvind@gmail.com", MobileNumber = "9090909090" };
                new CustomerModel { Id = 2, CName = "Bhanu", City = "Mumbai", Email = "bhanu@gmail.com", MobileNumber = "8089786756" };
            
        };
        }
        public List<CustomerModel> GetAll()
        {
            return Customers;
        }
        public CustomerModel GetByid(int id)
        {
            return Customers.Single(x => x.Id == id);
        }
        public void AddCustomer(CustomerModel c)
        {
            Customers.Add(c);
        }
        public void Edit(CustomerModel c, int id)
        {
            int index = Customers.FindIndex(x => x.Id == id);
            Customers[index] = c;
        }
        public void Delete(int id)
        {
            int index = Customers.FindIndex(x => x.Id == id);
            Customers.RemoveAt(index);
        }
    } 
}
