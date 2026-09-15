using ByMyPcDesktop.ConnectToApi.Models;

namespace ByMyPcDesktop.ConnectToApi.GetServices
{
    public interface ICpuGetService
    {
        Task<IEnumerable<CpuModelGet>?> GetFull();
        Task<IEnumerable<CpuSmallModel>?> GetSmallModel();
        Task<IEnumerable<CpuModelGet>?> GetWithPagFullAsync(int page, int pageSize);
        Task<IEnumerable<CpuModelGet>?> SearchByName(string name);
    }
}