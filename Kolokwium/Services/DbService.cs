using Kolokwium.Data;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task AddNewItemToCharacter(IEnumerable<Backpack> backpacks)
    {
        await _context.AddRangeAsync(backpacks);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> DoesItemExists(int itemId)
    {
        return await _context.Items.AnyAsync(e => e.Id == itemId);

    }

    //
    // public async Task<int> GetItemWeight(int itemId)
    // {
    //     return await _context.Items.Where(e => e.Id == itemId);
    // }
    //
    //
    // public Task<Character> GetCharacter(int characterId)
    // {
    //     return await _context.Items.Where()
    // }
    
    
    public async Task<ICollection<Character>> GetCharacter(int characterId)
    {
        return await _context.Characters
            .Where(e => characterId == null || e.Id == characterId)
            .ToListAsync();
    }

    



}