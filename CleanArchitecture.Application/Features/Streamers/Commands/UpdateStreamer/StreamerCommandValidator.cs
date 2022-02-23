using System;
using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
	public class StreamerCommandValidator : AbstractValidator<UpdateStreamerCommand>
	{
		public StreamerCommandValidator()
		{
			RuleFor(p => p.Nombre).NotNull()
								 .WithMessage("{Nombre} no permite nulos");
			RuleFor(p => p.Url).NotNull()
							 .WithMessage("{Url} no permite nulos");
		}
	}
}

