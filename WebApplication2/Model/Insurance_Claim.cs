using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class Insurance_Claim
    {
        public int Customer_Id { get; set; }

        public string Customer_Name { get; set; }
        [Key]
        public int Insurance_Id { get; set; }

        public int Policy_Id { get; set; }

        public string Vehicle_Number { get; set; }

        public string Insured_Company { get; set; }

        public string Policy_Name { get; set; }

        public DateTime Policy_Apply_Date { get; set; }

        public DateTime Policy_StartDate { get; set; }

        public DateTime Policy_EndDate { get; set; }


        public string Claim_Status { get; set; }

    }
}
