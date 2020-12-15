using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace VEdger.Models
{
    public class MatchStatus
    {
        [Required]
        [Key]
        public Int64 id { get; set; }
        public int primary_user_id { get; set; }
        public int secondary_user_id { get; set; }
        public Relationship relationship { get; set; }
        public string conversation_fs_path { get; set; }

        //relacja  //to check if needed nawadays
        public virtual UserData PrimaryUser { get; set; }
        public virtual UserData SecondaryUser { get; set; }
    }
}