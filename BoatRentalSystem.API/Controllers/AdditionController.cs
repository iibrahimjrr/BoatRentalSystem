namespace BoatRentalSystem.API.Controllers;

using AutoMapper;
using BoatRentalSystem.API.ViewModel;
using BoatRentalSystem.Application;
using BoatRentalSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AdditionController : ControllerBase
{
    private readonly AdditionService _additionService;
    private readonly IMapper _mapper;

    public AdditionController(AdditionService additionService, IMapper mapper)
    {
        _additionService = additionService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AdditionViewModel>>> Get()
    {
        var Addition = await _additionService.GetAllAdditions();
        var AdditionViewModel = _mapper.Map<IEnumerable<AdditionViewModel>>(Addition);
        return Ok(AdditionViewModel);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AdditionViewModel>> Get(int id)
    {
        var Addition = await _additionService.GetAdditionById(id);
        if (Addition == null)
        {
            return NotFound();
        }
        var AdditionViewModel = _mapper.Map<AdditionViewModel>(Addition);
        return Ok(AdditionViewModel);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] AddAdditionViewModel addAdditionViewModel)
    {
        var Addition = _mapper.Map<Addition>(addAdditionViewModel);
        await _additionService.AddAddition(Addition);
        return CreatedAtAction(nameof(Get), new { id = Addition.Id }, addAdditionViewModel);
    }

    [HttpPut]
    public async Task<ActionResult> Put(AdditionViewModel AdditionViewModel)
    {
        var existingAddition = await _additionService.GetAdditionById(AdditionViewModel.Id);
        if (existingAddition == null)
        {
            return NotFound();
        }
        var Addition = _mapper.Map<Addition>(AdditionViewModel);
        await _additionService.UpdateAddition(Addition);
        return Ok(Addition);

    }
    [HttpDelete]
    public async Task<ActionResult> Delete(int id)
    {
        var existingAddition = await _additionService.GetAdditionById(id);
        if (existingAddition == null)
        {
            return NotFound();
        }
        await _additionService.DeleteAddition(id);
        return NoContent();
    }
}