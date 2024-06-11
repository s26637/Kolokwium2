using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;


public class Character
{
    
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    
    [MaxLength(120)]
    public string LastName { get; set; } = string.Empty;

    public int CurrentWei { get; set; }
    
    public int MaxWeight { get; set; }

}