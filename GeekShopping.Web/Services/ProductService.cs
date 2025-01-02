using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client = new HttpClient();
        public const string BasePath = "/api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            string ApiAction = "FindAll";
            HttpResponseMessage response = await _client.GetAsync($"{BasePath}/{ApiAction}");
            return await response.ReadContentAs<IEnumerable<ProductModel>>(); 

        }
        public async Task<ProductModel> FindProductById(long id)
        {
            string ApiAction = "FindById";
            var response = await _client.GetAsync($"{BasePath}/{ApiAction}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            string ApiAction = "Create";
            var response = await _client.PostAsJson($"{BasePath}/{ApiAction}", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Something went wrong when calling API");
        }
        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            string ApiAction = "Update";
            var response = await _client.PutAsJson($"{BasePath}/{ApiAction}", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeleteProductById(long id)
        {
            string ApiAction = "Delete";
            var response = await _client.DeleteAsync($"{BasePath}/{ApiAction}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Something went wrong when calling API");
        }



    }
}
