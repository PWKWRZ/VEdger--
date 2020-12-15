using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace VEdger.Models
{
    public class Photos
    {
        [Required]
        [Key]
        public int id { get; set; }
        public string fs_path { get; set; }
        [ForeignKey("UserData")] //to check if needed
        public int user_id { get; set; }

        //relacja  //to check if needed nawadays
        public virtual UserData User { get; set; }
    }
}