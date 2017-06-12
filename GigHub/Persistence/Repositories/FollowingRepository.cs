using GigHub.Models;
using System.Linq;

namespace GigHub.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly IApplicationDbContext _context;

        public FollowingRepository(IApplicationDbContext context)
        {
            _context = context;
        }


        public Following GetFollowing(string userId, string followeeId)
        {
            return _context.Followings
                     .Where(f => f.FolloweeId == followeeId && f.FollowerId == userId)
                     .SingleOrDefault();
        }

    }
}