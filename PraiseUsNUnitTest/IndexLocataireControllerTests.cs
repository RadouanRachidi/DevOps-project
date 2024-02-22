using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using PraiseUs.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Net.Http;
using Microsoft.Extensions.Options;
using Moq; 

namespace PraiseUs.Tests.Controllers
{
    [TestFixture]
    public class IndexLocataireControllerTests
    {
        private Mock<ApplicationDbContext> _mockContext;
        private Mock<DbSet<Locataire>> _mockDbSet;
        private IndexLocataireController _controller;
        private Mock<ClaimsPrincipal> _mockUser;



        [SetUp]
        public void Setup()
        {
            // Créer des options pour le contexte de base de données en mémoire
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Utiliser le constructeur avec des options pour mocker ApplicationDbContext
            _mockContext = new Mock<ApplicationDbContext>(options);

            var locataires = new List<Locataire>
                {
                    new Locataire { Id_Users = "testUserId1" }, // Assurez-vous que les IDs sont uniques
                    new Locataire { Id_Users = "testUserId2" }
                }.AsQueryable();

            _mockDbSet = new Mock<DbSet<Locataire>>();
            _mockDbSet.As<IQueryable<Locataire>>().Setup(m => m.Provider).Returns(locataires.Provider);
            _mockDbSet.As<IQueryable<Locataire>>().Setup(m => m.Expression).Returns(locataires.Expression);
            _mockDbSet.As<IQueryable<Locataire>>().Setup(m => m.ElementType).Returns(locataires.ElementType);
            _mockDbSet.As<IQueryable<Locataire>>().Setup(m => m.GetEnumerator()).Returns(locataires.GetEnumerator());

            _mockContext.Setup(ctx => ctx.Locataire).Returns(_mockDbSet.Object);

            // Setup user claims
            _mockUser = new Mock<ClaimsPrincipal>();
            var claim = new Claim(ClaimTypes.NameIdentifier, "testUserId");
            _mockUser.Setup(u => u.Claims).Returns(new List<Claim> { claim });

            // Setup HttpContext
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(m => m.User).Returns(_mockUser.Object);

            // Create controller
            _controller = new IndexLocataireController(_mockContext.Object)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = mockHttpContext.Object
                }
            };
        }


        [Test]
        public async Task Index_ReturnsViewWithLocataires()
        {
            // Act
            var result = await _controller.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            var model = viewResult.Model as List<Locataire>;
            Assert.IsNotNull(model);
            Assert.AreEqual(2, model.Count);
        }

    }
}
