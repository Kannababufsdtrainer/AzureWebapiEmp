using EmpCrud.Models;
using Microsoft.Data.SqlClient;
namespace EmpCrud.Repo
{
    public class EmpRepo : IEmpRepo
    {
        private readonly string constring;
        public EmpRepo(IConfiguration configuration)
        {
            constring = configuration.GetConnectionString("getcon")!;

        }
        public void Add(Employee emp)
        {
            SqlConnection con = new SqlConnection(constring); ;
            con.Open();
            string query = "insert into employees(eno,ename,sal,adharno,phno) values(@eno,@ename,@sal,@adharno,@phno)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@eno", emp.Eno);
            cmd.Parameters.AddWithValue("@ename", emp.Ename);
            cmd.Parameters.AddWithValue("@sal", emp.Sal);
            cmd.Parameters.AddWithValue("@adharno", emp.Adharno);
            cmd.Parameters.AddWithValue("@phno", emp.Phoneno);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmps()
        {
            Models.Employee emp = new Employee();
            List<Models.Employee> emps = new List<Employee>();
            SqlConnection con = new SqlConnection(constring); ;
            con.Open();
            string query = "select * from employees";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.CommandType=System.Data.CommandType.Text;
           SqlDataReader dr=cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emps.Add(new Employee()
                    {
                        Eno = Convert.ToInt32(dr[0]),
                        Ename = dr[1].ToString(),
                        Sal = Convert.ToDecimal(dr[2]),
                        Adharno = Convert.ToInt64(dr[3]),
                       Phoneno = Convert.ToInt64(dr[4]),
                    });
                }
            }
           dr.Close();
            return emps;
        }

        public void Update(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
