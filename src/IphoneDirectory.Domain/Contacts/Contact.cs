using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace IphoneDirectory.Contacts
{
    public class Contact : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }        
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
    }
}
