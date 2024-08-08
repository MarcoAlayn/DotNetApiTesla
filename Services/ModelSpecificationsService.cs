using dotnetapitesla.Interfaces;
using dotnetapitesla.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetapitesla.Services
{
    public class ModelSpecificationsService : IModelSpecifications
    {
        private readonly CarSalesDbContext _context;

        public ModelSpecificationsService(CarSalesDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ModelSpecification>> GetModelSpecifications()
        {
            var modelSpecifications = await _context.ModelSpecifications.FromSqlRaw("EXEC sp_GetAllModelSpecifications @Action=0").ToListAsync();
            return modelSpecifications;
        }

    }
}
