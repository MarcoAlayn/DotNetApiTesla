using dotnetapitesla.Models;

namespace dotnetapitesla.Interfaces
{
    public interface IModelSpecifications
    {
        Task<IEnumerable<ModelSpecification>> GetModelSpecifications();
    }
}
