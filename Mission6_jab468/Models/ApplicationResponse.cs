using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jab468.Models
{
    public class ApplicationResponse
    {
        //Category, title, year, Director first Name, Director Last Name, Rating (drop down menue(G,pg,pg-13,R)), Edited (yes/no), , Lent to, Notes
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title {get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string DirectorFirstName { get; set; }
        [Required]
        public string DirectorLastName { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string notes { get; set; }
    }
}
