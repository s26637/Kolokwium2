using Kolokwium.Models;

namespace Kolokwium.Services;

public interface IDbService
{
    
    public Task AddNewItemToCharacter(IEnumerable<Backpack> orderPastries);

    public Task<bool> DoesItemExists(int itemId);
    public Task<ICollection<Character>> GetCharacter(int characterId);

    //
    // public Task<int> GetItemWeight(int itemId);
    //
    // public Task<Character> GetCharacter(int characterId);

}