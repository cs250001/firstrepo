using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet(Name = "GetEmployees")]
        public List<Employee> Get()
        {
            List<Employee> lstUser = new List<Employee>();
            string cs = "data source=.; database=chan; integrated security=SSPI";
            SqlConnection d = new SqlConnection(cs);
            string q = "select * from test3";
            SqlDataAdapter da = new SqlDataAdapter(q, d);

            DataSet dt = new DataSet();
            da.Fill(dt);
            foreach(DataRow f in dt.Tables[0].Rows)
            {
                Employee user = new Employee();
                user.name = f[1].ToString();
                user.gender = f[2].ToString();
                user.depid = ((int)f[3]);
                lstUser.Add(user);

                    
            }
            //tis is test

            //List<User> lstUser = new List<User>();
            //User user = new User();
            //user.FirstName = "Prince";
            //user.LastName = "Kumar";
            //user.Age = 36;
            //lstUser.Add(user);
            //user = new User();
            //user.FirstName = "Charanjit";
            //user.LastName = "Singh";
            //user.Age = 36;
            //lstUser.Add(user);
            return lstUser;

            ;
        }
    }
}

