using Danielson.Data.Data;
using Danielson.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Danielson.Data.DataAccess {

    public class FormAccess(FormRepository formRepository) {
        private readonly FormRepository _formRepository = formRepository;

        public async Task<Form> GetForm(int id) => await _formRepository.ReadAsync(f => f.Forms.Include(form => form.ComponentAnswers).Include(form => form.DomainAnswers).FirstOrDefault(form => form.Id == id)) ?? new();

        public async Task<int> Save(ComponentAnswer componentAnswer) => componentAnswer.Id > 0
                ? await _formRepository.UpdateAsync(componentAnswer)
                : await _formRepository.CreateAsync(componentAnswer);

        public async Task<int> Save(DomainAnswer domainAnswer) => domainAnswer.Id > 0
                ? await _formRepository.UpdateAsync(domainAnswer)
                : await _formRepository.CreateAsync(domainAnswer);

        public async Task<int> Save(Form form) => await _formRepository.UpdateAsync(form);
    }
}