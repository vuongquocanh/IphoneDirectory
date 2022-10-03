using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace IphoneDirectory.Contacts
{
    public class ContactDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
    }
}
