﻿using GigHub.Controllers.Api;
using GigHub.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace GigHub.Test.Controllers.Api
{
    [TestClass]
    public class GigControllerTests
    {
        private GigsController _controller;

        public GigControllerTests()
        {
            var identity = new GenericIdentity("user1@domain.com");
            identity.AddClaim(
                new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "user1@domain.com"));
            identity.AddClaim(
                new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "1"));

            var principal = new GenericPrincipal(identity, null);

            var mockUoW = new Mock<IUnitOfWork>();
            var controller = new GigsController(mockUoW.Object);
            //controller.user
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
