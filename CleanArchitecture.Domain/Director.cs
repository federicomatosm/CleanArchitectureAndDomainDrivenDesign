using System;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain
{
	public class Director : BaseDomainModel
    {
        
        public string? Nombre { get; set; }
        public string?  Apellidos { get; set; }

        public int VideoId { get; set; }
        public virtual Video? Video { get; set; }
    }
}

