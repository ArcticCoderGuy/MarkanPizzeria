using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarkanPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; } = string.Empty;
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; } = string.Empty;

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
