using System;
namespace CleanArchitecture.Application.Exceptions
{
	public class NotFoundException : ApplicationException
	{
		public NotFoundException(string name, object key) : base($"Entit \"{name}\" ({key}) no fue encontrado")
		{
		}
	}
}

