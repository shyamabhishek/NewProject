using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }

        public string Customer_Name { get; set; }

        public string Contact_Details { get; set; }

        [ForeignKey("Policy_Start_Date")]
        public DateTime Policy_StartDate { get; set; }

        [ForeignKey("Policy_EndDate")]
        public DateTime Policy_EndDate { get; set; }

        [ForeignKey("Vehicle_Number")]
        public string Vehicle_Number { get; set; }

        public string Insured_Company { get; set; }

        [ForeignKey("Policy_Apply_Date")]
        public DateTime Policy_Apply_Date { get; set; }


    }
}
