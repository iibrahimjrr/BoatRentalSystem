using BoatRentalSystem.Core.Entities;
using BoatRentalSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentalSystem.Infrastructure
{
    public class AdditionRepository : BaseRepository<Addition>, IAdditionRepository
    {
        public AdditionRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        //private readonly List<Addition> _addition = new List<Addition>();

        //public AdditionRepository()
        //{
        //    _addition = new List<Addition>
        //    {
        //        new Addition { Id = 1, Name = "Test1" },
        //        new Addition { Id = 2, Name = "Test2" },
        //        new Addition { Id = 3, Name = "Test3" },
        //    };
        //}
        //public async Task AddAddition(Addition addition)
        //{
        //    addition.Id = _addition.Any() ? _addition.Max(c => c.Id) + 1 : 1;
        //    _addition.Add(addition);
        //    await Task.CompletedTask;
        //}

        //public async Task DeleteAddition(int id)
        //{
        //    var addition = _addition.FirstOrDefault(c => c.Id == id);
        //    if (addition != null)
        //        _addition.Remove(addition);

        //    await Task.CompletedTask;
        //}

        //public async Task<Addition> GetAdditionById(int id)
        //{
        //    var addition = _addition.FirstOrDefault(c => c.Id == id);
        //    return await Task.FromResult(addition);
        //}

        //public async Task<IEnumerable<Addition>> GetAllAdditions()
        //{
        //    return await Task.FromResult(_addition);
        //}

        //public async Task UpdateAddition(Addition addition)
        //{
        //    var existingAddition = _addition.FirstOrDefault(x => x.Id == addition.Id);
        //    if (existingAddition != null)
        //    {
        //        existingAddition.Name = addition.Name;
        //    }
        //    await Task.CompletedTask;
        //}
    }
}
