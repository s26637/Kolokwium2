namespace Kolokwium.DTOs;

public class GetCharacterDTO
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int currentWeigh { get; set; }
    public int maxWeight { get; set; }

    public ICollection<GetCharacterBackpackDTO> Backpacks = new List<GetCharacterBackpackDTO>();



}

public class GetCharacterBackpackDTO
{
    
    public int CharacterId { get; set; }
    
    public int ItemId { get; set; }
    
    public int Amount { get; set; }
    
}
