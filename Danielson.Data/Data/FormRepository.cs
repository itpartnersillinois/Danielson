using Danielson.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Danielson.Data.Data {

    public class FormRepository(IDbContextFactory<FormContext> factory) {
        private readonly IDbContextFactory<FormContext> _factory = factory;

        public int ChangeActive<T>(T item, bool active) where T : BaseDataItem {
            using var context = _factory.CreateDbContext();
            item.LastUpdated = DateTime.Now;
            item.IsActive = active;
            _ = context.Update(item);
            return context.SaveChanges();
        }

        public async Task<int> ChangeActiveAsync<T>(T item, bool active) where T : BaseDataItem {
            using var context = _factory.CreateDbContext();
            item.LastUpdated = DateTime.Now;
            item.IsActive = active;
            _ = context.Update(item);
            return await context.SaveChangesAsync();
        }

        public int Create<T>(T item) where T : BaseDataItem {
            using var context = _factory.CreateDbContext();
            item.LastUpdated = DateTime.Now;
            item.IsActive = true;
            _ = context.Add(item);
            return context.SaveChanges();
        }

        public async Task<int> CreateAsync<T>(T item) where T : BaseDataItem {
            using var context = _factory.CreateDbContext();
            item.LastUpdated = DateTime.Now;
            item.IsActive = true;
            _ = context.Add(item);
            return await context.SaveChangesAsync();
        }

        public int Delete<T>(T item) where T : BaseDataItem {
            if (item == null) {
                return 0;
            }
            using var context = _factory.CreateDbContext();
            _ = context.Remove(item);
            return context.SaveChanges();
        }

        public async Task<int> DeleteAsync<T>(T item) where T : BaseDataItem {
            if (item == null) {
                return 0;
            }
            using var context = _factory.CreateDbContext();
            _ = context.Remove(item);
            return await context.SaveChangesAsync();
        }

        public T Read<T>(Func<FormContext, T> work) where T : BaseDataItem {
            var context = _factory.CreateDbContext();
            return work(context);
        }

        public async Task<T> ReadAsync<T>(Func<FormContext, T> work) where T : BaseDataItem? {
            var context = _factory.CreateDbContext();
            return await Task.Run(() => work(context));
        }

        public int Update<T>(T item) where T : BaseDataItem {
            using var context = _factory.CreateDbContext();
            item.LastUpdated = DateTime.Now;
            _ = context.Update(item);
            return context.SaveChanges();
        }

        public async Task<int> UpdateAsync<T>(T item) where T : BaseDataItem {
            using var context = _factory.CreateDbContext();
            item.LastUpdated = DateTime.Now;
            _ = context.Update(item);
            return await context.SaveChangesAsync();
        }
    }
}