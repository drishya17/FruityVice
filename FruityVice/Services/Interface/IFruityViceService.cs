using FruityVice.Models;

namespace FruityVice.Services.Interface
{
    public interface IFruityViceService
    {
        public List<FruitDto> GetFruitsByFamilyService(string family);
        public List<FruitDto> GetAllFruitsService();
    }
}
