using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PodLynk.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserID { get; set; }
        public DateTime UpdatedAt { get; set; }
       
    }

}