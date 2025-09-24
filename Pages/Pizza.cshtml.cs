using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MarkanPizzeria.Models;  

namespace MarkanPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB { get; } = new()
        {
            new PizzasModel { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
            new PizzasModel { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
            new PizzasModel { ImageTitle = "Seafood",   PizzaName = "Seafood",   BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
            
        };

        public void OnGet() { }
    }
}

