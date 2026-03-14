using ProjetoFênix.Models;

namespace ProjetoFenix.Services
{
    public interface IInventoryService
    {
        List<Item> GetAll();
        Item? GetById(int id);
        void Add(Item item);
        void Update(int id, Item item);
        void Delete(int id);
    }
}