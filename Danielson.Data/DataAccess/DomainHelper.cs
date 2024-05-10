using Danielson.Data.Data;
using Danielson.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Danielson.Data.DataAccess {

    public class DomainHelper(FormRepository formRepository) {
        private readonly FormRepository _formRepository = formRepository;

        public async Task<DomainTemplate> GetTemplate(int id) => await _formRepository.ReadAsync(r => r.DomainTemplates.Include(d => d.ComponentTemplates).ThenInclude(c => c.ComponentOptionTemplates).FirstOrDefault(d => d.Id == id)) ?? new DomainTemplate();

        public async Task<int> SaveTemplate(DomainTemplate d) => await _formRepository.UpdateAsync(d);
    }
}