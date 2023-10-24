using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int Customer_Id, string Customer_Name, string Contact_Details, DateTime Policy_Period, string Vehicle_Number, string Insured_Company, DateTime policy_Apply_Date)
        {
            return new string[] { "Customer_Id","Customer_Name", " Contact_Details", " Policy_Period", "Vehicle_Number", "Insured_Company", "Policy_Apply_Date" };
        }

        // GET api/values/5
        [HttpGet("{Customer_Id}")]
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
        [HttpPut("{Customer_Id}")]
        public void Put(int Customer_Id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{Customer_Id}")]
        public void Delete(int Customer_Id)
        {
        }
    }
}
