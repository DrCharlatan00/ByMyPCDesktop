using ByMyPcDesktop.ConnectToApi.Models;

namespace ByMyPcDesktop.ConnectToApi.GetServices.CPUService
{
    public interface ICpuGetService
    {
        Task<Guid?> CreateAsync(DTOCpuCreateModel model);
        Task<CpuModelGet?> GetByID(Guid id);
        Task<IEnumerable<CpuModelGet>?> GetFull();
        Task<IEnumerable<CpuSmallModel>?> GetSmallModel();
        Task<IEnumerable<CpuModelGet>?> GetWithPagFullAsync(int page, int pageSize);
        Task<IEnumerable<CpuModelGet>?> SearchByName(string name);
        Task<CpuModelGet?> UpdateAsync(DTOCpuUpdateModel model);
    }
}