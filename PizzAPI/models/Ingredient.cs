using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzAPI.models;

namespace PizzAPI.models
{
    public class Ingredient
    {
     
        [Column("id")]
        public int Id { get; set; }


        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

 
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
    }
}

