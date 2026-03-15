using ProjetoFênix.Models;
using System.Xml.Linq;

namespace ProjetoFênix.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly List<Item> _items = new List<Item>();
        private int _nextId = 1;

        public List<Item> GetAll()
        {
            return _items;
        }

        public Item? GetById(int id)
        {
            return _items.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Item item)
        {
            item.Id = _nextId++;
            _items.Add(item);
        }

        public void Update(int id, Item itemAtualizado)
        {
            var item = GetById(id);
            if (item == null) return;

            item.Nome = itemAtualizado.Nome;
            item.Quantidade = itemAtualizado.Quantidade;
            item.Categoria = itemAtualizado.Categoria;
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
                _items.Remove(item);
        }
    }
}