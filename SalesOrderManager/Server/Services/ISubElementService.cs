using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Services
{
    public interface ISubElementService
    {
        Task Delete(int id);
        Task Update(SubElement subelement);
        Task<SubElement> Add(SubElement subelement);
    }
}
