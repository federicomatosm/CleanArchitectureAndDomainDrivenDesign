using System;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts.Persintence
{
	public interface IVideoRepository : IAsyncRepository<Video>
	{
		Task<Video> GetVideoByNombre(string nombreVideo);
		Task<IEnumerable<Video>> GetVideoByUserName(string username);
	}
}

