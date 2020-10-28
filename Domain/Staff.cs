using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Domain
{
    public class Staff
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Role { get; set; }
    }
}
