using AutoMapper;
using BoatRentalSystem.API.ViewModel;
using BoatRentalSystem.Core.Entities;

namespace BoatRentalSystem.API.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityViewModel>().ReverseMap();
            CreateMap<City, AddCityViewModel>().ReverseMap();

            CreateMap<Country, CountryViewModel>().ReverseMap();
            CreateMap<Country, AddCountryViewModel>().ReverseMap();

            CreateMap<Addition, AdditionViewModel>().ReverseMap();
            CreateMap<Addition, AddAdditionViewModel>().ReverseMap();

            CreateMap<Package, PackageViewModel>().ReverseMap();
            CreateMap<Package, AddPackageViewModel>().ReverseMap();

        }
    }
}
