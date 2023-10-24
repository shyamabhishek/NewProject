using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class Policy
    {
        [ForeignKey("Policy_Id")]
        public int Policy_Id { get; set; }

        [ForeignKey("Policy_Name")]
        public string Policy_Name { get; set; }



    }
}
