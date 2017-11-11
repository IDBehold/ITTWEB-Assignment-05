using System.ComponentModel.DataAnnotations.Schema;

namespace Embedded_Stock.Models
{
    public class CategoryComponentType
    {
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("ComponentType")]
        public long ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }
    }
}