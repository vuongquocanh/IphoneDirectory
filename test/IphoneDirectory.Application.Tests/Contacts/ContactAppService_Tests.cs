using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace IphoneDirectory.Contacts
{
    public class ContactAppService_Tests : IphoneDirectoryApplicationTestBase
    {
        private readonly IContactAppService _contactAppService;

        public ContactAppService_Tests()
        {
            _contactAppService = GetRequiredService<IContactAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Contacts()
        {
            //Act
            var result = await _contactAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Name == "Vuong Quoc Anh");
        }

        [Fact]
        public async Task Should_Create_A_Valid_Contact()
        {
            //Act
            var result = await _contactAppService.CreateAsync(
                new CreateUpdateContactDto
                {
                    Name = "Nguyen Xuan Quynh",
                    Email = "quynhnx@gmail.com",
                    Mobile = "0325123154"
                }
            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Name.ShouldBe("Nguyen Xuan Quynh");
        }

        [Fact]
        public async Task Should_Not_Create_A_Contact_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _contactAppService.CreateAsync(
                    new CreateUpdateContactDto
                    {
                        Name = "",
                        Email = "quynhnx@gmail.com",
                        Mobile = "0325123154"
                    }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
        }
    }
}
