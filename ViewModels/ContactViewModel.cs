using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.ViewModels
{
    /*
     * HELP: Client-side validation doesn't work for Name field, MinLength ("Required" DOES work for both)
     */

    public class ContactViewModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Message too long")]
        public string Message { get; set; }
    }
}
