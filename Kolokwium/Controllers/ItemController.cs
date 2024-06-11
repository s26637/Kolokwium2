using System.Transactions;
using Kolokwium.DTOs;
using Kolokwium.Models;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ItemController
    : ControllerBase
{
    private readonly IDbService _dbService;
    public ItemController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpPost("api/characters/{characterId}/backpacks")]
    public async Task<IActionResult> AddItemToCharacter(int characterId, NewItemDTO newItemDto)
    {
        
        
        var items = new List<Backpack>();
        
        foreach (var itemID in newItemDto.Items)
        {

            
            if (!await _dbService.DoesItemExists(itemID))
                return NotFound($"Item not exists");
            
            {
                
            }

            items.Add(new Backpack()
            {
                CharacterId = characterId,
                ItemId = itemID,
                Amount = 1
            });
        }
       
        
    
        using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            await _dbService.AddNewItemToCharacter(items);
            
            scope.Complete();
        }
        
        
        return Ok("api/orders");
        
    }
}