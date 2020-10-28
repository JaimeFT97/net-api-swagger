using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Domain
{
    public class Artist
    {
        public  int Id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Artistic_name { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Real_name { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public Country Country { get; set; }
        public int Country_id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public float Average_salary { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Occupation { get; set; }

        
    }
}
