using FruityVice.Controllers;
using FruityVice.Models;
using FruityVice.Services;
using FruityVice.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FruityVice.Tests
{
    /// <summary>
    /// FruityViceControllerTest
    /// </summary>
    public class FruityViceControllerTest
    {
        public readonly FruityViceController _controller;
        public readonly IFruityViceService _service;
        public readonly IHttpClientFactory _httpClientFactory;
        public FruityViceControllerTest(IFruityViceService _service)
        {
            _service = new FruityViceService();
            _controller = new FruityViceController(_service);
        }

        [Fact]
        public void GetAllFruitTestCase()
        {
            var result = _controller.GetAll();
            Assert.IsType<OkResult>(result as OkObjectResult);
        }

        [Fact]
        public void GetAllFruitByFamily()
        {
            var family = new Family
            {
                FruitFamily = "Orange"
            };
            var result = _controller.GetFruitsByFamily(family);
            Assert.IsType<OkResult>(result as OkObjectResult);
        }
    }
}