using System;
using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Phone { get; set; }
        public string Major { get; set; }
        public bool CreeperStalker { get; set; }
            
    
    }
}
