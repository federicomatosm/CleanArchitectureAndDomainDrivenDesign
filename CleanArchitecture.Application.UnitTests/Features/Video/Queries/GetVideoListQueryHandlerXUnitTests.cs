using AutoMapper;
using CleanArchitecture.Application.Contracts.Persintence;
using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using CleanArchitecture.Application.Mappings;
using CleanArchitecture.Application.UnitTests.Mocks;
using Moq;
using Xunit;
using Shouldly;
using CleanArchitecture.Infrastructure.Repositories;

namespace CleanArchitecture.Application.UnitTests.Features.Video.Queries
{
	public class GetVideoListQueryHandlerXUnitTests
	{
		private readonly IMapper _mapper;
		private readonly Mock<UnitOfWork> _unitOfWork;

        public GetVideoListQueryHandlerXUnitTests()
        {
			_unitOfWork = MockUnitOfWork.GetUnitOfWork();
			var mapperConfig = new MapperConfiguration(c =>
			{
				c.AddProfile<MappingProfile>();
			});

			_mapper = mapperConfig.CreateMapper();

			MockVideoRepository.AddDataVideoRepository(_unitOfWork.Object.StreamerDbContext);
        }


		[Fact]
		public async Task GetVideoListTest()
        {
			var handler = new GetVideoListQueryHandler(_unitOfWork.Object, _mapper);
			var request = new GetVideosListQuery("System");
			var result = await handler.Handle(request, CancellationToken.None);

			result.ShouldBeOfType<List<VideosVm>>();

			result.Count.ShouldBe(1);
        }
	}
}

