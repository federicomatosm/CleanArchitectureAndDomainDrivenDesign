﻿using System;
using AutoMapper;
using CleanArchitecture.Application.Contracts.Persintence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
	public class UpdateStreamerCommandHandler : IRequestHandler<UpdateStreamerCommand>
	{
        // private readonly IStreamerRepository _streamerRepository; changed to use UnitOfWork
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateStreamerCommandHandler> _logger;

        public UpdateStreamerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateStreamerCommandHandler> logger)
        {
            // _streamerRepository = streamerRepository ?? throw new ArgumentNullException(nameof(streamerRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Unit> Handle(UpdateStreamerCommand request, CancellationToken cancellationToken)
        {
            // var streamerToUpdate = await _streamerRepository.GetByIdAsync(request.Id);

            var streamerToUpdate = await _unitOfWork.StreamerRepository.GetByIdAsync(request.Id);

            if (streamerToUpdate == null)
            {
                _logger.LogError($"No se encontro el streamer id {request.Id}");
                throw new NotFoundException(nameof(Streamer), request.Id);
            }

            _mapper.Map(request, streamerToUpdate, typeof(UpdateStreamerCommand), typeof(Streamer));


            // await _streamerRepository.UpdateAsync(streamerToUpdate);
             _unitOfWork.StreamerRepository.UpdateEntity(streamerToUpdate);
            await _unitOfWork.Complete();
            _logger.LogInformation($"Se actualizo correctamente el streamer {request.Id}");

            return Unit.Value;
        }
    }
}

