﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Cats.Models;
using Cats.Services.Administration;
using Cats.Web.Adminstration.Controllers;
using Cats.Web.Adminstration.Models.ViewModels;
using Kendo.Mvc.UI;
using Moq;
using NUnit.Framework;

namespace Cats.Web.Adminstration.Tests.ControllerTest
{
    [TestFixture]
    public class HubOwnerControllerTest
    {
        private HubOwnerController _hubOwnerController;

        #region SetUp
        [SetUp]
        public void Init()
        {
            var hubOwner = new List<HubOwner>
               {
                   new HubOwner {HubOwnerID = 1,Name = "Owner1",LongName = "Hub Owner 1"},
                   new HubOwner {HubOwnerID = 2,Name = "Owner2",LongName = "Hub Owner 2"}

               };
            var hubOwnerService = new Mock<IHubOwnerService>();
            hubOwnerService.Setup(m => m.GetAllHubOwner()).Returns(hubOwner);
            _hubOwnerController = new HubOwnerController(hubOwnerService.Object);
        }

        [TearDown]
        public void Dispose()
        {
            _hubOwnerController.Dispose();
        }
        #endregion
        #region Test
        [Test]
        public void CanShowIndex()
        {
            var result = _hubOwnerController.Index();
            Assert.IsNotNull(result);
        }

        [Test]
        public void CanReadHubOwner()
        {
            var request = new DataSourceRequest();
            var result = _hubOwnerController.Read(request);

            Assert.IsInstanceOf<JsonResult>(result);
        }
        [Test]
        public void CanCreateHubOwner()
        {
            var request = new DataSourceRequest();
            var hubOwnerViewModel = new HubOwnerViewModel { HubOwnerID = 1, HubId = 1, Name = "Owner2", LongName = "Hub Owner 2" };

            var result = _hubOwnerController.HubOwnerCreate(request, hubOwnerViewModel);
            //Assert
            Assert.IsInstanceOf<JsonResult>(result);
        }
        [Test]
        public void CanUpdateHubOwner()
        {
            var request = new DataSourceRequest();
            var hubOwnerViewModel = new HubOwnerViewModel { HubOwnerID = 1, HubId = 1, Name = "Owner2", LongName = "Hub Owner 2" };

            var result = _hubOwnerController.HubOwnerUpdate(request, hubOwnerViewModel);
            //Assert
            Assert.IsInstanceOf<JsonResult>(result);
            Assert.IsNotNull(result);
        }
        [Test]
        public void CanDestroyHubOwner()
        {
            var request = new DataSourceRequest();
            var hubOwnerViewModel = new HubOwnerViewModel { HubOwnerID = 1, HubId = 1, Name = "Owner2", LongName = "Hub Owner 2" };

            var result = _hubOwnerController.HubOwnerUpdate(request, hubOwnerViewModel);
            //Assert
            Assert.IsInstanceOf<JsonResult>(result);

        }
        #endregion
    }
}
