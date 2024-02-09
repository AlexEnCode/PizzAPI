using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzAPI.models
{
    [Table("IngredientPizza")]
    public class PizzaIngredient
    {
        public int Id { get; set; } 
            
        [Column("pizza_id")]
        public int PizzaId { get; set; }
              public Pizza? Pizza { get; set; }

        [Column("ingredient_id")]
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}
