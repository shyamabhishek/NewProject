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
    public class Insurance_ClaimController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int Customer_Id, string Customer_Name, int Insurance_Id, int Policy_Id, string Vehicle_Number, string Insured_Company, string Policy_Name, DateTime policy_Apply_Date, DateTime Policy_StartDate, DateTime Policy_EndDate, string Claim_Status)
        {
            return new string[] { "Customer Id", "Customer_Name", "Insurance_Id", "Policy_Id", "Vehicle_Number", "Insured_Company", "Policy_Name", "Policy_Apply_Date", "Policy_StartDate", "Policy_EndDate","Claim_Status" };
        }

        // GET api/values/5
        [HttpGet("{Customer_Id}")]
        public ActionResult<string> Get()
        {
            return "value";
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