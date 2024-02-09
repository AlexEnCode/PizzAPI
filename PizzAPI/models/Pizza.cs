using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PizzAPI.models
{
    [Table("pizza")]
    public class Pizza
    {
      
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }


        [Column("price")]
        [Precision(37,2)]
        public decimal Price { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("isVegetarian")]
        public bool IsVegetarian { get; set; }

        [Column("isSpicy")]
        public bool IsSpicy { get; set; }

        [Column("ingrediant")]
        public List<Ingredient> Ingredients { get; set; }
    }
}
