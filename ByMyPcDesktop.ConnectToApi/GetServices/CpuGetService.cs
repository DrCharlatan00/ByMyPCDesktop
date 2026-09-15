using ByMyPcDesktop.ConnectToApi.Models;
using System.Net.Http.Json;


namespace ByMyPcDesktop.ConnectToApi.GetServices
{
    public class CpuGetService(HttpClient httpClient) : ICpuGetService
    {
        private readonly HttpClient httpClient = httpClient;

        public async Task<IEnumerable<CpuModelGet>?> GetFull()
        {
            var request = await httpClient.GetAsync("/api/cpu/full");

            if (!request.IsSuccessStatusCode) return null;

            return await request.Content.ReadFromJsonAsync<IEnumerable<CpuModelGet>>();

        }

        public async Task<IEnumerable<CpuSmallModel>?> GetSmallModel() {
            var request = await httpClient.GetAsync("/api/cpu/");

            if (!request.IsSuccessStatusCode) return null;

            return await request.Content.ReadFromJsonAsync<IEnumerable<CpuSmallModel>>();
        }

        public async Task<IEnumerable<CpuModelGet>?> GetWithPagFullAsync(int page, int pageSize) {
            var request = await httpClient.GetAsync($"/api/cpu/full-pag?page={page}&pageSize={pageSize}");

            if (!request.IsSuccessStatusCode) return null;

            return await request.Content.ReadFromJsonAsync<IEnumerable<CpuModelGet>>();
        }

        public async Task<IEnumerable<CpuModelGet>?> SearchByName(string name) {
            var request = await httpClient.GetAsync($"/api/cpu/search-name?name={name}");

            if (!request.IsSuccessStatusCode) return null;

            return await request.Content.ReadFromJsonAsync<IEnumerable<CpuModelGet>>();
        }
    }
}
