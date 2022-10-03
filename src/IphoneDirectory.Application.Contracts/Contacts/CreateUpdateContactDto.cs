using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IphoneDirectory.Contacts
{
    public class CreateUpdateContactDto
    {
        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [Required]
        [RegularExpression(@"(84|0[3|5|7|8|9])+([0-9]{8})\b", ErrorMessage = "Please enter the correct format!")]
        public string Mobile { get; set; }

        public string Company { get; set; }

        public string Title { get; set; }
    }
}
