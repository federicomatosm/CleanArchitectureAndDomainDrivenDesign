using System;
using AutoMapper;
using CleanArchitecture.Application.Contracts.Persintence;
using MediatR;

namespace CleanArchitecture.Application.Features.Videos.Queries.GetVideosList
{
    public class GetVideoListQueryHandler : IRequestHandler<GetVideosListQuery, List<VideosVm>>
    {

        //private readonly IVideoRepository _videoRepository;  changed to use UnitOfWork
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetVideoListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            //_videoRepository = videoRepository ?? throw new ArgumentNullException(nameof(videoRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<VideosVm>> Handle(GetVideosListQuery request, CancellationToken cancellationToken)
        {
            var videoList = await _unitOfWork.VideoRepository.GetVideoByUserName(request._Username);

            return _mapper.Map<List<VideosVm>>(videoList);
        }
    }
}

