using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("KEntryConnectUserTable")]
    public class UserAccount
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Username is Requred")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Requred")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Select the gender")]
        public string Gender { get; set; }
        [Required]
        public string UserType { get; set; }
    }
}