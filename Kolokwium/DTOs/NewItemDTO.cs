using System.ComponentModel.DataAnnotations;

namespace Kolokwium.DTOs;

public class NewItemDTO
{
    
    [Required]
    public List<int> Items { get; set; } = new List<int>();
    
}

public class NewItemCharacterDTO
{
    [Required] public int ItemId { get; set; }

}
