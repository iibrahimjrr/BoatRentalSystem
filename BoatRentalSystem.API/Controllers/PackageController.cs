namespace BoatRentalSystem.API.Controllers;

using AutoMapper;
using BoatRentalSystem.API.ViewModel;
using BoatRentalSystem.Application;
using BoatRentalSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class PackageController : ControllerBase
{
    private readonly PackageService _packageService;
    private readonly IMapper _mapper;

    public PackageController(PackageService packageService, IMapper mapper)
    {
        _packageService = packageService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PackageViewModel>>> Get()
    {
        var Package = await _packageService.GetAllPackages();
        var PackageViewModel = _mapper.Map<IEnumerable<PackageViewModel>>(Package);
        return Ok(PackageViewModel);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PackageViewModel>> Get(int id)
    {
        var Package = await _packageService.GetPackageById(id);
        if (Package == null)
        {
            return NotFound();
        }
        var PackageViewModel = _mapper.Map<PackageViewModel>(Package);
        return Ok(PackageViewModel);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] AddPackageViewModel addPackageViewModel)
    {
        var Package = _mapper.Map<Package>(addPackageViewModel);
        await _packageService.AddPackage(Package);
        return CreatedAtAction(nameof(Get), new { id = Package.Id }, addPackageViewModel);
    }

    [HttpPut]
    public async Task<ActionResult> Put(PackageViewModel PackageViewModel)
    {
        var existingPackage = await _packageService.GetPackageById(PackageViewModel.Id);
        if (existingPackage == null)
        {
            return NotFound();
        }
        var Package = _mapper.Map<Package>(PackageViewModel);
        await _packageService.UpdatePackage(Package);
        return Ok(Package);

    }
    [HttpDelete]
    public async Task<ActionResult> Delete(int id)
    {
        var existingPackage = await _packageService.GetPackageById(id);
        if (existingPackage == null)
        {
            return NotFound();
        }
        await _packageService.DeletePackage(id);
        return NoContent();
    }
}