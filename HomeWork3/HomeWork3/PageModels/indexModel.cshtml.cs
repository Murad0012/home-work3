using HomeWork3.Data;
using HomeWork3.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork3.PageModels
{
    public class indexModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = ProductRepository.GetProducts();
        }
    }
}
