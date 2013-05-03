using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace griffinfujioka_Boostrap.Models
{
    public class EmailMessage
    {
        [DisplayName("EmailMessage")]
        [Required(ErrorMessage = "Please tell me your name!")]
        public string Name { get; set; }

        public string FromEmailAddress { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}