namespace BoatRentalSystem.Infrastructure
{
    using BoatRentalSystem.Core.Entities;
    using BoatRentalSystem.Core.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        //private readonly List<City> _cities = new List<City>();
        //public CityRepository()
        //{
        //    _cities = new List<City>
        //    { 
        //        new City { Id = 1, Name = "Test1" },
        //        new City { Id = 2, Name = "Test2" },
        //        new City { Id = 3, Name = "Test3" },
        //    };
        //}
        //public async Task AddCity(City city)
        //{
        //    city.Id = _cities.Any() ? _cities.Max(c => c.Id) + 1 : 1;
        //    _cities.Add(city);
        //    await Task.CompletedTask;
        //}

        //public async Task DeleteCity(int id)
        //{
        //    var city = _cities.FirstOrDefault(c => c.Id == id);
        //    if (city != null)
        //        _cities.Remove(city);

        //    await Task.CompletedTask;
        //}

        //public async Task<IEnumerable<City>> GetAllCities()
        //{
        //    return await Task.FromResult(_cities);
        //}


        //public async Task<City> GetCityById(int id)
        //{
        //    var city = _cities.FirstOrDefault(c => c.Id == id);
        //    return await Task.FromResult(city);
        //}

        //public async Task UpdateCity(City city)
        //{
        //    var existingCity = _cities.FirstOrDefault(x => x.Id == city.Id);
        //    if (existingCity != null)
        //    {
        //        existingCity.Name = city.Name;
        //    }
        //    await Task.CompletedTask;
        //}
    }
}
