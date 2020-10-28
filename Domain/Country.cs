using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace net_api_swagger.Domain
{
    public class Country
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field cannot be empty")]
        public string Country_name { get; set; }
    }
}
