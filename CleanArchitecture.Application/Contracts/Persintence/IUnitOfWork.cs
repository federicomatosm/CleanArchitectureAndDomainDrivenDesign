﻿using System;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Contracts.Persintence
{
    public interface IUnitOfWork : IDisposable
	{
        IStreamerRepository StreamerRepository { get; }
        IVideoRepository VideoRepository { get; }

        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;
        Task<int> Complete();
	}
}

