using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HomeWork1.Controllers
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }


    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static List<Users> users = new List<Users>()
        {
            new Users {FirstName = "Vasko", LastName = "Pecanov", Age = 26},
            new Users {FirstName = "Bruce", LastName = "Wayne", Age = 36},
            new Users {FirstName = "Bugha", LastName = "Bugha", Age = 16},
            new Users {FirstName = "Bobby", LastName = "Axelroad", Age = 46}
        };

        [HttpGet]
        public ActionResult<List<Users>> Get()
        {
            return users;
        }

        [HttpGet("{index}")]
        public ActionResult<Users> Get(int index)
        {
            try
            {
                return users[index - 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                return NotFound($"You are out of bounds mate with your index: {index}");
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message} Bad Request MATE!!");
            }
        }

        [HttpGet("check/{id}")]
        public IActionResult Check(int id)
        {
            try
            {
                var person = users[id - 1];
                if (person.Age >= 18)
                {
                    return Ok($"{person.FirstName} is an adult");
                }
                else
                {
                    return Ok($"{person.FirstName} is still kid");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return NotFound($"There is no person with the id: {id}");
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}, Bad request mate!!!");
            }
        }

        [HttpPost]
        public IActionResult Post()
        {
            string body;
            using(StreamReader sr = new StreamReader(Request.Body))
            {
                body = sr.ReadToEnd();
            }
            Users user = JsonConvert.DeserializeObject<Users>(body);
            users.Add(user);
            return Ok($"{user.FirstName} has been added");
        }

    }
}