using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Domain
{
    public class Album
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Album_name { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Album_cover { get; set; }
        public int Song_quantity { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Duration { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Link_album { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public Artist Artist { get; set; }
        public int Artist_id { get; set; }
    }
}
