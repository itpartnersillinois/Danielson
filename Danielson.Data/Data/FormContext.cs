using System.Diagnostics;
using Danielson.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Danielson.Data.Data {

    public class FormContext : DbContext {
        private readonly Guid _id;

        public FormContext() : base() {
            _id = Guid.NewGuid();
            Debug.WriteLine($"{_id} context created.");
        }

        public FormContext(DbContextOptions<FormContext> options) : base(options) {
            _id = Guid.NewGuid();
            Debug.WriteLine($"{_id} context created.");
        }

        public DbSet<ComponentAnswer> ComponentAnswers { get; set; }
        public DbSet<ConsiderationTemplate> ConsiderationTemplates { get; set; }
        public DbSet<DomainAnswer> DomainAnswers { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormTemplate> FormTemplates { get; set; }
        public DbSet<User> Users { get; set; }

        public override void Dispose() {
            Debug.WriteLine($"{_id} context disposed.");
            base.Dispose();
        }

        public override ValueTask DisposeAsync() {
            Debug.WriteLine($"{_id} context disposed async.");
            return base.DisposeAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            Debug.WriteLine($"{_id} context starting initial setup.");
            _ = modelBuilder.Entity<User>().HasData(new List<User> {
                new() { Id = -1, Email = "admin@illinois.edu", Guid = Guid.Parse("BE31303E-404A-471C-B7C0-DFDEA01A4121"), IsActive = false, LastUpdated = DateTime.Now, Role = RoleEnum.Admin, Username = "admin" },
                new() { Id = -2, Email = "student@illinois.edu", Guid = Guid.Parse("3784cb3c-681f-45b0-9b67-391ca17f5c0f"), IsActive = false, LastUpdated = DateTime.Now, Role = RoleEnum.Student, Username = "student" },
                new() { Id = -3, Email = "supervisor@illinois.edu", Guid = Guid.Parse("50924bd6-1494-4c5c-a064-81b8aabedfa2"), IsActive = false, LastUpdated = DateTime.Now, Role = RoleEnum.Supervisor, Username = "supervisor" },
                new() { Id = -4, Email = "cotestaff@illinois.edu", Guid = Guid.Parse("b1dfc3d3-b726-4946-a65f-9489d360662f"), IsActive = false, LastUpdated = DateTime.Now, Role = RoleEnum.CoteStaff, Username = "cotestaff" },
            });
            _ = modelBuilder.Entity<Form>().HasData(new List<Form> {
                new() { Id = 1, DateEvaluated = DateTime.Now, DateSubmitted = DateTime.Now, FormTemplateInternalLookupString = "default", Email = "test@illinois.edu", IsActive = true, LastUpdated = DateTime.Now, ShowComponents = true, ShowNotObserved = true, ShowQuantitativeAnswer = true, Title = "Test form"},
            });

            Debug.WriteLine($"{_id} context finishing initial setup.");
        }
    }
}