using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admin_DetailsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int Admin_Id)
        {
            return new string[] { "Admin Id", "Admin Name" };
        }

        // GET api/values/5
        [HttpGet("{Admin_Id}")]
        public ActionResult<string> Get()
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{Admin_Id}")]
        public void Put(int Admin_Id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{Customer_Id}")]
        public void Delete(int Admin_Id)
        {
        }
    }
}