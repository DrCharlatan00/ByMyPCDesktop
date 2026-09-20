using ByMyPcDesktop.ConnectToApi.Models;

namespace ByMyPcDesktop.ConnectToApi.GetServices
{
    public interface ICpuGetService
    {
        Task<CpuModelGet?> GetByID(Guid id);
        Task<IEnumerable<CpuModelGet>?> GetFull();
        Task<IEnumerable<CpuSmallModel>?> GetSmallModel();
        Task<IEnumerable<CpuModelGet>?> GetWithPagFullAsync(int page, int pageSize);
        Task<IEnumerable<CpuModelGet>?> SearchByName(string name);
    }
}