using FruityVice.Models;
using FruityVice.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FruityVice.Controllers
{
    [ApiController]
    [Route("/api/")]
    public class FruityViceController : ControllerBase
    {
       
        private readonly IFruityViceService _fruityViceService;

        public FruityViceController(IFruityViceService fruityViceService)
        {
           this._fruityViceService= fruityViceService;
        }

        #region "GET Calls"
        [HttpGet]
        [Route("fruit/all")]
        public IActionResult GetAll() =>
            (IActionResult)Ok(this._fruityViceService.GetAllFruitsService());

        [HttpPost]
        [Route("fruit/family")]
        public IActionResult GetFruitsByFamily(Family family) =>
            (IActionResult)Ok(this._fruityViceService.GetFruitsByFamilyService(family.FruitFamily));


        #endregion
    }
}