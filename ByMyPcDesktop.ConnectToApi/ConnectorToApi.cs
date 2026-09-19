using ByMyPcDesktop.ConnectToApi.Exceptions;
using ByMyPcDesktop.ConnectToApi.GetServices;
using ByMyPcDesktop.ConnectToApi.Models;
using System.Xml.Linq;

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
            IEnumerable<CpuModelGet>? data = await cpuService.GetWithPagFullAsync(page, pageSize);
            if (data is null) throw new ApiGetException();
            return data;
        }

        public async Task<IEnumerable<CpuModelGet>> SearchByNameCpu(string name)
        {
            var data = await cpuService.SearchByName(name);
            if (data is null) throw new ApiGetException();
            return data;

        }

        public async Task<CpuModelGet?> GetByIDCPU(string id) {

            if (Guid.TryParse(id, out Guid res))
            {
                var data = await cpuService.GetByID(res);
                if (data is null) return null;
                return data;
            }
            throw new ArgumentException("Wrong GUID, Parse reject id");
        }


    }
}
