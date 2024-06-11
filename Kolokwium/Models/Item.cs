using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;

public class Item
{
    [Key]
    public int Id { get; set; }

    [MaxLength(120)] 
    public string Name { get; set; } = string.Empty;


    public int Weight { get; set; }


}