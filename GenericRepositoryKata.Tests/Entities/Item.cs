using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryKata.Tests.Entities
{
    public sealed class Item
    {
        public Item(int id, string itemId, string category)
        {
            Id = id;
            ItemId = itemId;
            Category = category;
        }

        public int Id { get; private set; }
        public string ItemId { get; private set; }
        public string Category { get; private set; }
    }
}
