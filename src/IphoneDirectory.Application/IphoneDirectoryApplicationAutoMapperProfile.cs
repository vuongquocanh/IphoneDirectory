using AutoMapper;
using IphoneDirectory.Contacts;

namespace IphoneDirectory;

public class IphoneDirectoryApplicationAutoMapperProfile : Profile
{
    public IphoneDirectoryApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Contact, ContactDto>();
        CreateMap<CreateUpdateContactDto, Contact>();
    }
}
