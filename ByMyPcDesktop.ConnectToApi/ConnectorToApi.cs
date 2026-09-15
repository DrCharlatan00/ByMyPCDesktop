using ByMyPcDesktop.ConnectToApi.Exceptions;
using ByMyPcDesktop.ConnectToApi.GetServices;
using ByMyPcDesktop.ConnectToApi.Models;

namespace ByMyPcDesktop.ConnectToApi
{
    public class ConnectorToApi
    {
        public HttpClient HttpClient { get; set; } = new();
        ICpuGetService cpuService;
        public ConnectorToApi(Uri uriToApi)
        {
            HttpClient.BaseAddress = uriToApi;
            cpuService = new CpuGetService(HttpClient); 
        }

        public async Task<IEnumerable<CpuModelGet>> GetFullCpusAsync() {
            IEnumerable<CpuModelGet>? data = await cpuService.GetFull();
            if (data is null) throw new ApiGetException();
            return data;
        }

        public async Task<IEnumerable<CpuSmallModel>> GetCpuSmallsAsync() {
            IEnumerable<CpuSmallModel>? data = await cpuService.GetSmallModel();
            if (data is null) throw new ApiGetException();
            return data;
        }

        public async Task<IEnumerable<CpuModelGet>> GetWithPagFull(int page, int pageSize) 
        {
            IEnumerable<CpuModelGet>? data = await cpuService.GetWithPagFullAsync(page,pageSize);
            if (data is null) throw new ApiGetException();
            return data;
        }
    }
}
