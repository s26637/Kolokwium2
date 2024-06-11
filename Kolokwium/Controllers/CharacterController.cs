using Kolokwium.DTOs;
using Kolokwium.Models;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers;



[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    
       private readonly IDbService _dbService;
        public CharacterController(IDbService dbService)
        {
            _dbService = dbService;
        }
        
     [HttpGet("api/characters/{characterId}")]
     public async Task<IActionResult> GetOrdersData(int characterId)
        {
            var orders = await _dbService.GetCharacter(characterId);
            
            return Ok(orders.Select(e => new GetCharacterDTO()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                currentWeigh = e.CurrentWei,
                maxWeight = e.MaxWeight
                
            }));
        }
    
    
}

   
   
