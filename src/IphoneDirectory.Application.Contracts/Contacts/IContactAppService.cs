using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace IphoneDirectory.Contacts
{
    public interface IContactAppService : ICrudAppService<ContactDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateContactDto>
    {

    }
}
