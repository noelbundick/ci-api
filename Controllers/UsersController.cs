using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private static readonly List<User> Users = new List<User> {
            new User(1, "Noel Bundick"),
            new User(2, "Totes McGoats")
        };
        private readonly List<User> _users;
        
        public UsersController() : this(Users) {}
        
        public UsersController(List<User> users)
        {
            _users = users;
        }
        
        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User value)
        {
            _users.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User value)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
                _users.Add(value);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
                _users.Remove(user);
        }
    }
}
