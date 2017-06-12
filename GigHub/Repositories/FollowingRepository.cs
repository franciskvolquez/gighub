﻿using GigHub.Models;
using System.Linq;

namespace GigHub.Repositories
{
    public class FollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
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