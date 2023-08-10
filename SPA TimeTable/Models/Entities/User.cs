using System.ComponentModel.DataAnnotations;

namespace SPA_TimeTable.Models.Entities;

public class User
{
    [Key]
    [MaxLength(16)]
    public string Login { get; set; }
    [Required]
    [MaxLength(32)]
    public string Pasword { get; set; }
    public IEnumerable<TimeTable> TimeTable { get; set; }
}