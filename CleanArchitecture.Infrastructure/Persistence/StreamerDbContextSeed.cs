using System;
using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Infrastructure.Persistence
{
	public class StreamerDbContextSeed
	{
		public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContextSeed> logger)
        {
            if (!context.Streamers!.Any())
            {
               await context.Streamers.AddRangeAsync(GetPreConfigureStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Se insertaron los datos preconfigurados al db context {context}", typeof(StreamerDbContext).Name);
            }
        }

        private static IEnumerable<Streamer> GetPreConfigureStreamer()
        {
            return new List<Streamer>
            {
                new Streamer
                {
                    CreatedBy ="Federico",
                    Nombre="Amazon VIP",
                    Url="http://amazonvip.com"
                },
                  new Streamer
                {
                    CreatedBy ="Federico",
                    Nombre="Axe",
                    Url="http://Axestream.com"
                }
            };
        }
	}
}

