﻿using AutoFixture;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories;

namespace CleanArchitecture.Application.UnitTests.Mocks
{
	public static class MockVideoRepository
	{
		public static void AddDataVideoRepository(StreamerDbContext streamerDbContextFake)
        {
			var fixture = new Fixture();
			fixture.Behaviors.Add(new OmitOnRecursionBehavior());
			var videos = fixture.CreateMany<Video>().ToList();

			videos.Add(fixture.Build<Video>()
				.With(tr => tr.CreatedBy, "System")
				.Create()
				);

			
						
			streamerDbContextFake.Videos!.AddRange(videos);
			streamerDbContextFake.SaveChanges();

	
        }
	}
}

