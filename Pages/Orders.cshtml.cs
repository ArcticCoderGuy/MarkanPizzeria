using MarkanPizzeria.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MarkanPizzeria.Models; 

namespace MarkanPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrder = new List<PizzaOrder>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

            PizzaOrder = _context.PizzaOrders.ToList();

        }
    }
}
