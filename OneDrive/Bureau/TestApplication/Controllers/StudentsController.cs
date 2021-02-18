using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public static List<Students> Get_Students()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(){Id = 1, First_Name = "Surname1", Last_Name = "Name1", Age = 20});
            students.Add(new Students(){Id = 1, First_Name = "Surname2", Last_Name = "Name2", Age = 19});
            students.Add(new Students(){Id = 1, First_Name = "Surname3", Last_Name = "Name3", Age = 20});
            students.Add(new Students(){Id = 1, First_Name = "Surname4", Last_Name = "Name4", Age = 21});
            students.Add(new Students(){Id = 1, First_Name = "Surname5", Last_Name = "Name5", Age = 20});
            return students;
        }

        [HttpGet]
        public IEnumerable<Students> GetGames_List()
        {
            return Get_Students();
        }
    }
}