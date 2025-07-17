using BoatRentalSystem.Core.Entities;
using BoatRentalSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentalSystem.Infrastructure;

public class PackageRepository : BaseRepository<Package>, IPackageRepository
{
    public PackageRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    //private readonly List<Package> _package = new List<Package>();
    //public PackageRepository()
    //{
    //    _package = new List<Package>
    //    {
    //        new Package { Id = 1, Name = "Test1" },
    //        new Package { Id = 2, Name = "Test2" },
    //        new Package { Id = 3, Name = "Test3" },
    //    };
    //}
    //public async Task AddPackage(Package package)
    //{
    //    package.Id = _package.Any() ? _package.Max(c => c.Id) + 1 : 1;
    //    _package.Add(package);
    //    await Task.CompletedTask;
    //}

    //public async Task DeletePackage(int id)
    //{
    //    var Package = _package.FirstOrDefault(c => c.Id == id);
    //    if (Package != null)
    //        _package.Remove(Package);

    //    await Task.CompletedTask;
    //}

    //public async Task<IEnumerable<Package>> GetAllPackages()
    //{
    //    return await Task.FromResult(_package);
    //}

    //public async Task<Package> GetPackageById(int id)
    //{
    //    var Package = _package.FirstOrDefault(c => c.Id == id);
    //    return await Task.FromResult(Package);
    //}

    //public async Task UpdatePackage(Package package)
    //{
    //    var existingPackage = _package.FirstOrDefault(x => x.Id == package.Id);
    //    if (existingPackage != null)
    //    {
    //        existingPackage.Name = package.Name;
    //    }
    //    await Task.CompletedTask;
    //}
}
