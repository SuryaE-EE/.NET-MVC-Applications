using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    public class ProductsController : Controller
    {
              ProductBO context = new ProductBO();
            // GET: ProductsController
            public async Task<IActionResult> Index()
            {
                List<ProductModel> products = await context.GetProductsAsync(); // Await the async method

                if (products == null)
                {
                    // Handle null products (e.g., return an error view)
                    return View("Error"); // Or another appropriate action
                }

                // Now, products is a List<ProductModel>, not a Task
                return View(products); // Pass the list to the view
            }

    }
}






    

