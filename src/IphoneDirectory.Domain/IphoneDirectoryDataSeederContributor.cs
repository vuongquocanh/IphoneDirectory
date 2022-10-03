using IphoneDirectory.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace IphoneDirectory
{
    public class IphoneDirectoryDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Contact, Guid> _contactRepository;
        public IphoneDirectoryDataSeederContributor(IRepository<Contact, Guid> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _contactRepository.GetCountAsync() > 0)
            {
                return;
            }

            await _contactRepository.InsertAsync(
                new Contact
                {
                    Name = "Vuong Quoc Anh",
                    Email = "quocanhvuong111@gmail.com",
                    Mobile = "0366274232"
                },
                autoSave: true
            );

            await _contactRepository.InsertAsync(
                new Contact
                {
                    Name = "Nguyen Minh Hang",
                    Email = "MinHan@gmail.com",
                    Mobile = "0323455667"
                }, autoSave: true);

            await _contactRepository.InsertAsync(
                new Contact
                {
                    Name = "Nguyen Minh Quan",
                    Email = "MinQuan@gmail.com",
                    Mobile = "0941584685"
                }, autoSave: true);

            await _contactRepository.InsertAsync(
                new Contact
                {
                    Name = "Tran Nhat Minh",
                    Email = "NhatMinh@gmail.com",
                    Mobile = "0358469587"
                }, autoSave: true);
        }
    }
}
