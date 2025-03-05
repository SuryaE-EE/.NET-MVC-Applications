using System.Data.SqlClient;
namespace DataApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cs = "server=KIRAN\\SQLEXPRESS;user id=sa;password=welcome;database=EmployeeDB";

            string cs = "server=DESKTOP-FHBRPJ7;integrated security=true;database=Surya";

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            /* string query = "select * from EMP";
             SqlCommand cmd = new SqlCommand(query, cn);

             SqlDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
              {

                  Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}");
              }*/


            /*if (dr.Read()) //return current row and forward pointer to next row
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} {dr[3].ToString()} ");*/

            /*string query = "select * from EMP where EMPNO=@EMPNO";
            SqlCommand cmd = new SqlCommand(query, cn);


            Console.Write("Enter id to search: ");
            int EMPNO = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
            
            

            SqlDataReader dr = cmd.ExecuteReader();    //This method used to issue select statement returning rows

            if (dr.Read()) //return current row and forward pointer to next row
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} {dr[3].ToString()} ");
            else
                Console.WriteLine($"{EMPNO} not exist...");
            */
            Console.Write("Enter id: ");
            int EMPNO = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ename: ");
            string ENAME = Console.ReadLine();

            Console.Write("Enter job: ");
            string JOB = Console.ReadLine();

            Console.Write("Enter salary: ");
            int SAL = Convert.ToInt32(Console.ReadLine());

            string query = "insert into tb1Employees values (@EMPNO, @ENAME, @JOB, @SAL)";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
            cmd.Parameters.AddWithValue("@ENAME", ENAME);
            cmd.Parameters.AddWithValue("@JOB", JOB);
            cmd.Parameters.AddWithValue("@SAL", SAL);

            int count = cmd.ExecuteNonQuery();  //To issue any command other than select like insert or delete or update
            Console.WriteLine($"{count} rows added successfully..");





        }
    }
}