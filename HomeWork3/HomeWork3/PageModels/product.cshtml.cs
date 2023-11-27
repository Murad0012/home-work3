using HomeWork3.Data;
using HomeWork3.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork3.Pages
{
    public class productModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet() => Products = ProductRepository.GetProducts();
    }
}
