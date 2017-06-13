﻿using GigHub.Persistence;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class GigsController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public GigsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var gig = _unitOfWork.Gigs.GetGigWithAttendees(id);

            if (gig == null)
                return NotFound();

            if (gig.ArtistId != userId)
                return Unauthorized();

            if (gig.IsCanceled)
                return NotFound();

            gig.Cancel();

            _unitOfWork.Complete();

            return Ok();
        }
    }
}
