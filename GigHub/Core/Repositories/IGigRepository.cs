using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IGigRepository
    {
        void Add(Gig gig);
        Gig GetGig(int id);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithArtistAndGenre(int gigId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetMyGigs(string userId);
    }
}