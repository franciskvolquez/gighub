using System.Data.Entity;

namespace GigHub.Models
{
    public interface IApplicationDbContext
    {
        DbSet<Genre> Genres { get; set; }
        DbSet<Gig> Gigs { get; set; }
    }
}