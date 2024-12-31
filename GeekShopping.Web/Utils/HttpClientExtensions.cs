using System.Text.Json;

namespace GeekShopping.Web.Utils
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException
                    (
                    $"Algo aconteceu de errado chamando a Api: " +
                    $"{response.ReasonPhrase}");
            }
            else
            {
                var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var jsonSerializeOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var dataAsJson = JsonSerializer.Deserialize<T>(dataAsString, jsonSerializeOptions);
                return dataAsJson;

            }
        }
    }
}
