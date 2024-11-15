using MainDVLD.HttpConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Globals
{
    public interface IApiClient<T>
    {
        Task<List<T>> GetAllAsync(string endpoint);
        Task<T> GetByIdAsync(string endpoint, int id);
        Task<bool> CreateAsync(string endpoint, T entity);
        Task<bool> UpdateAsync(string endpoint, int id, T entity);
        Task<bool> DeleteAsync(string endpoint, int id);
    }

    public class ApiClient<T> : IApiClient<T>
    {
        private static readonly HttpClient _httpClient = HttpConnection.HttpClientSingleton.Instance;

       // private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
           // _httpClient = httpClient;
        }

        public async Task<List<T>> GetAllAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<T>>();
        }

        public async Task<T> GetByIdAsync(string endpoint, int id)
        {
            var response = await _httpClient.GetAsync($"{endpoint}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<bool> CreateAsync(string endpoint, T entity)
        {
            var response = await _httpClient.PostAsJsonAsync(endpoint, entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(string endpoint, int id, T entity)
        {
            var response = await _httpClient.PutAsJsonAsync($"{endpoint}/{id}", entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(string endpoint, int id)
        {
            var response = await _httpClient.DeleteAsync($"{endpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
