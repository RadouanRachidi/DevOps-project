using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using PraiseUS.Controllers;
using PraiseUS.Models;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Http;

[TestFixture]
public class HomeControllerTests
{
    private HomeController controller;

    [SetUp]
    public void Setup()
    {
        controller = new HomeController(new NullLogger<HomeController>());
    }

    [Test]
    public void Index_Returns_ViewResult()
    {
        // 
        var result = controller.Index();

        Assert.IsInstanceOf<ViewResult>(result);
    }

    [Test]
    public void Privacy_Returns_ViewResult()
    {
        var result = controller.Privacy();

        Assert.IsInstanceOf<ViewResult>(result);
    }

    [Test]
    public void Error_Returns_ViewResult_With_ErrorViewModel()
    {
        // Arrange
        var httpContext = new DefaultHttpContext(); 
        controller.ControllerContext = new ControllerContext()
        {
            HttpContext = httpContext
        };

        var result = controller.Error();

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = result as ViewResult;
        Assert.IsInstanceOf<ErrorViewModel>(viewResult.Model);
    }

}
