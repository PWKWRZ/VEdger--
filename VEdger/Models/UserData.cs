using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace VEdger.Models
{
    public class UserData
    {
        [Required]
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        [Timestamp]
        public byte[] created_at { get; set; }
        public string location { get; set; }
        public FoodPreferenceEnum food_preference {get; set; }
        public string description { get; set; }

        //relacja  //to check if needed nawadays
        public virtual ICollection<Photos> UserPhotos{ get; set; }
        public virtual ICollection<MatchStatus> MatchStatus{ get; set; }
    }
}