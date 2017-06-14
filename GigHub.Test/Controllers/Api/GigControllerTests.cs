using FluentAssertions;
using GigHub.Controllers.Api;
using GigHub.Models;
using GigHub.Persistence;
using GigHub.Repositories;
using GigHub.Test.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Http.Results;

namespace GigHub.Test.Controllers.Api
{
    [TestClass]
    public class GigControllerTests
    {
        private GigsController _controller;

        Mock<IGigRepository> _mockRepository;


        public GigControllerTests()
        {
            _mockRepository = new Mock<IGigRepository>();

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.SetupGet(u => u.Gigs).Returns(_mockRepository.Object);

            _controller = new GigsController(mockUoW.Object);
            _controller.MockCurrentUser("1", "user1@domain.com");
        }

        [TestMethod]
        public void Cancel_ShouldReturnNotFound_WhenNoGigWithGivenIdExists_()
        {
            var result = _controller.Cancel(1);

            result.Should().BeOfType<NotFoundResult>();
        }

        [TestMethod]
        public void Cancel_ShouldReturnNotFound_WhenGigIsCanceled()
        {
            var gig = new Gig();
            gig.Cancel();

            _mockRepository.Setup(r => r.GetGigWithAttendees(1)).Returns(gig);

            var result = _controller.Cancel(1);
            result.Should().BeOfType<NotFoundResult>();
        }


    }
}
