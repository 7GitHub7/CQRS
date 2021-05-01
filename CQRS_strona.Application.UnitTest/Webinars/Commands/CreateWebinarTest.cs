using AutoMapper;
using CQRS_strona.Application.Contract.Persistance;
using CQRS_strona.Application.Functions.Webinars.Command;
using CQRS_strona.Application.Mapper;
using CQRS_strona.Application.UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CQRS_strona.Application.UnitTest.Webinars.Commands
{
    public class CreateWebinaryTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IWebinaryRepository> _mockWebinarRepository;

        public CreateWebinaryTest()
        {
            _mockWebinarRepository = RepositoryMocks.GetWebinarRepository();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }
            );

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidWebinar_AddedToWebinarRepo()
        {
            var handler = new CreatedWebinarCommandHandler
                (_mockWebinarRepository.Object, _mapper);

            var allWebinarsBeforeCount = (await _mockWebinarRepository.Object.GetAllAsync()).Count;

            var command = new CreatedWebinarCommand()
            {
                ImageUrl = "TestTest",
                Title = new string('*', 80),
                FacebookEventUrl = "TestTest",
                Date = DateTime.Now.AddDays(-14),
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allWebinars = await _mockWebinarRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            response.ValidationErrors.Count.ShouldBe(0);
            allWebinars.Count.ShouldBe(allWebinarsBeforeCount + 1);
            response.Id.ShouldNotBeNull();
        }
    }
}
