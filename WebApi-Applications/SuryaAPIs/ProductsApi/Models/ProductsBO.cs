namespace ProductsApi.Models;
using System.Net.Http;

using System.Text;
using Newtonsoft.Json;


    public class ProductBO
    {
        private List<ProductModel> products = new List<ProductModel>();

    public async Task<List<ProductModel>> GetProductsAsync()
    {
        List<ProductModel> products = new List<ProductModel>(); // Initialize the list

        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri("https://fakestoreapi.com/");

            var response = await client.GetAsync("products"); // Use await, not .Result

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync(); // Read as string

                // Deserialize using Newtonsoft.Json
                products = JsonConvert.DeserializeObject<List<ProductModel>>(json);

                //Or if you are sure it is an array and not a list
                // ProductModel[] productArray = JsonConvert.DeserializeObject<ProductModel[]>(json);
                // products = new List<ProductModel>(productArray);


            }
            return products;
        } }

            

  



    }


