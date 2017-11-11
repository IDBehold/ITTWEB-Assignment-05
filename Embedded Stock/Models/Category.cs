using System.Collections.Generic;

namespace Embedded_Stock.Models
{
    public class Category
    {
        public Category() { ComponentTypes = new List<CategoryComponentType>(); }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryComponentType> ComponentTypes { get; protected set; }
    }
}