using System;
using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commands.CreateStreamer
{
	public class CreateStreamerCommandValidator: AbstractValidator<CreateStreamerCommand>
	{
		public CreateStreamerCommandValidator()
        {

			RuleFor(p => p.Nombre).NotEmpty()
								 .WithMessage("El nombre no puede estar vacio")
								 .NotNull()
								 .MaximumLength(50).WithMessage("El nombre no puede exceder los 50 caracteres");
			RuleFor(p => p.Url).NotEmpty()
								 .WithMessage("La {Url} puede estar en blanco");
		}
	}
}

