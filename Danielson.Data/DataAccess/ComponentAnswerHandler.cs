using Danielson.Data.Data;
using Danielson.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Danielson.Data.DataAccess {

    public class ComponentAnswerHandler(FormRepository formRepository) {
        private readonly FormRepository _formRepository = formRepository;

        public async Task<Form> GetForm(int id) => await _formRepository.ReadAsync(f => f.Forms.Include(form => form.ComponentAnswers).FirstOrDefault(form => form.Id == id)) ?? new();

        public async Task<int> Save(ComponentAnswer componentAnswer) => componentAnswer.Id > 0
                ? await _formRepository.UpdateAsync(componentAnswer)
                : await _formRepository.CreateAsync(componentAnswer);
    }
}