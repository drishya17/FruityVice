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
        /// <summary>
        /// GetAllfruits
        /// </summary>
        /// <returns>List</returns>
        [HttpGet]
        [Route("fruit/all")]
        public IActionResult GetAll() =>
            (IActionResult)Ok(this._fruityViceService.GetAllFruitsService());

        /// <summary>
        /// GetFruitsByFamily
        /// </summary>
        /// <param name="family"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("fruit/family")]
        public IActionResult GetFruitsByFamily(Family family) =>
            (IActionResult)Ok(this._fruityViceService.GetFruitsByFamilyService(family.FruitFamily));


        #endregion
    }
}