using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WomenEmpowerment.Models;

namespace WomenEmpowerment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public AppDbContext _context{get;}

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getUsers")]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpGet("{id}")]
        [Route("getById/{id:int}")]
        public ActionResult<User> Get(int id)
        {
            var data = _context.Users.FirstOrDefault(u => u.User_Id == id);
            return (data);
        }

        [HttpPost]
        [Route("newUser")]
        public ActionResult Post(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            //return Ok();
            return CreatedAtAction("Get", new { newUser.User_Id }, newUser);
        }
    }
}
