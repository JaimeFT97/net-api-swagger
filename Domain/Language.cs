using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Domain
{
    public class Language
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Language_name { get; set; }
    }
}
