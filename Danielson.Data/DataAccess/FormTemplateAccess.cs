using Danielson.Data.Data;
using Danielson.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Danielson.Data.DataAccess {

    public class FormTemplateAccess(FormRepository formRepository) {
        private readonly FormRepository _formRepository = formRepository;

        public async Task<FormTemplate> Get(int? id) => id.HasValue ? await _formRepository.ReadAsync(f => f.FormTemplates.Include(f => f.ConsiderationTemplates).FirstOrDefault(f => f.Id == id)) ?? new() { ConsiderationTemplates = new List<ConsiderationTemplate>() } : new() { ConsiderationTemplates = new List<ConsiderationTemplate>() };

        public async Task<FormTemplate> Get(string key) => await _formRepository.ReadAsync(f => f.FormTemplates.Include(f => f.ConsiderationTemplates).FirstOrDefault(f => f.InternalLookupString == key)) ?? new() { ConsiderationTemplates = new List<ConsiderationTemplate>() };

        public async Task<List<FormTemplate>> GetAll() => [.. (await _formRepository.ReadAsync(d => d.FormTemplates.OrderBy(a => a.Title)))];

        public async Task<int> Save(FormTemplate formTemplate) => formTemplate.Id > 0 ? await _formRepository.UpdateAsync(formTemplate) : await _formRepository.CreateAsync(formTemplate);
    }
}