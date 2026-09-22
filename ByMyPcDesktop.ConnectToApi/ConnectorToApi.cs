using ByMyPcDesktop.ConnectToApi.Exceptions;
using ByMyPcDesktop.ConnectToApi.GetServices;
using ByMyPcDesktop.ConnectToApi.GetServices.CPUService;
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

        public async Task<IEnumerable<CpuModelGet>> SearchByNameCpu(string name) 
        {
            var data = await cpuService.SearchByName(name);
            if (data is null) throw new ApiGetException();
            return data;

        }

        public async Task<CpuModelGet?> GetByID(string id) {
            if (!string.IsNullOrEmpty(id) && Guid.TryParse(id, out Guid res)) {
                var item = await cpuService.GetByID(res);
                return item;
            }
            throw new ArgumentException("Guid is wrong");
        }

        public async Task<CpuModelGet?> GetByID(Guid id) {
            return await cpuService.GetByID(id);
        }

        public async Task<CpuModelGet> UpdateAsync(DTOCpuUpdateModel model) {
            if (model.id == Guid.Empty) {
                throw new ArgumentException("Guid can't be null or empty, update abort");
            }
            CpuModelGet? result = await cpuService.UpdateAsync(model);
            if (result is null) throw new ApiOperationFailed<CpuModelGet>("Operation update is Failed");
            return result;
        }

    }
}
