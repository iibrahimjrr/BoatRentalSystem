using BoatRentalSystem.Core.Entities;
using BoatRentalSystem.Core.Interfaces;

namespace BoatRentalSystem.Application;

public class AdditionService
{
    private readonly IAdditionRepository _additionRepository;

    public AdditionService(IAdditionRepository additionRepository)
    {
        _additionRepository = additionRepository;
    }

    public Task<IEnumerable<Addition>> GetAllAdditions()
    {
        return _additionRepository.GetAllAsync();
    }
    public Task<Addition> GetAdditionById(int id)
    {
        return _additionRepository.GetByIdAsync(id);

    }
    public Task AddAddition(Addition addition)
    {
        return _additionRepository.AddAsync(addition);
    }

    public Task UpdateAddition(Addition addition)
    {
        return _additionRepository.UpdateAsync(addition.Id, addition);
    }

    public Task DeleteAddition(int id)
    {
        return _additionRepository.DeleteAsync(id);
    }
}
