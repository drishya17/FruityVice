using System.Text;
using Newtonsoft.Json;
using FruityVice.Services.Interface;
using FruityVice.Models;
using FruityVice.URLHelpers;

namespace FruityVice.Services
{
    /// <summary>
    /// FruityViceService
    /// </summary>
    public class FruityViceService : IFruityViceService
    {
        private readonly List<FruitDto> fruitList = new List<FruitDto>()
        {
            new FruitDto()
            {
               name ="Apple",
               id=1,
               family="Apple",
               order="1",
               genus="a",
               nutritions= new NutritionsDto
               {
                   calories=1,
                   fat=10,
                   carbohydrates=10,
                   sugar=10,
                   protein=10
               }
            },
            new FruitDto()
            {
               name ="Orange",
               id=1,
               family="Orange",
               order="1",
               genus="o",
               nutritions= new NutritionsDto
               {
                   calories=1,
                   fat=10,
                   carbohydrates=10,
                   sugar=10,
                   protein=10
               }
            }
        };

        public FruityViceService()
        {
        }

        /// <summary>
        /// GetAllFruitsService
        /// </summary>
        /// <returns></returns>
        public List<FruitDto> GetAllFruitsService()
        {
            var data = fruitList;
            return data;
        }

        /// <summary>
        /// GetFruitsByFamilyService
        /// </summary>
        /// <param name="family"></param>
        /// <returns></returns>
        public List<FruitDto> GetFruitsByFamilyService(string family)
        {
            var data = fruitList.Where(i => i.family == family).ToList();
            return data;
        }
    }

}