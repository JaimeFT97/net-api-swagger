using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Domain
{
    public class Song
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Song_name { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Duration { get; set; }

        public Gender Gender { get; set; }
        public int Gender_id { get; set; }

        public Language Language { get; set; }
        public int Language_id { get; set; }

        public Country Country { get; set; }
        public int Country_id { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public String Link_song { get; set; }

        public Album Album { get; set; }
        public int Album_id { get; set; }
        public Artist Artist { get; set; }
        public int Artist_id { get; set; }
    }
}
