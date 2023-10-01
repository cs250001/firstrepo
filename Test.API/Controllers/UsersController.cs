using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet(Name = "GetUsers")]
        public List<User> Get()
        {
            List<User> lstUser = new List<User>();
            User user = new User();
            user.FirstName = "Prince";
            user.LastName = "Kumar";
            user.Age = 36;
                lstUser.Add(user);
            user = new User();
            user.FirstName = "Charanjit";
            user.LastName = "Singh";
            user.Age = 36;
            lstUser.Add(user);
            return lstUser;

            ;
        }
        }
}
