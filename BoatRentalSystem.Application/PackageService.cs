using BoatRentalSystem.Core.Entities;
using BoatRentalSystem.Core.Interfaces;

namespace BoatRentalSystem.Application;

public class PackageService
{
    private readonly IPackageRepository _packageRepository;

    public PackageService(IPackageRepository packageRepository)
    {
        _packageRepository = packageRepository;
    }

    public Task<IEnumerable<Package>> GetAllPackages()
    {
        return _packageRepository.GetAllAsync();
    }
    public Task<Package> GetPackageById(int id)
    {
        return _packageRepository.GetByIdAsync(id);

    }
    public Task AddPackage(Package package)
    {
        return _packageRepository.AddAsync(package);
    }

    public Task UpdatePackage(Package package)
    {
        return _packageRepository.UpdateAsync(package.Id, package);
    }

    public Task DeletePackage(int id)
    {
        return _packageRepository.DeleteAsync(id);
    }

}
