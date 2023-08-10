using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPA_TimeTable.Models.Entities;

public class TimeTable
{
    public int Id { get; set; }
    [Required]
    [MaxLength(32)]
    public string? EventName { get; set; }
    [Required]
    [MaxLength(500)]
    public string? EventDescription { get; set; }
    
    public string? EventColor { get; set; }
    public DateTime EventBeginDateTime { get; set; }
    public DateTime EventEndDateTime { get; set; }
    
    public string? EventHolderLogin { get; set; }
    [ForeignKey("EventHolderLogin")]
    public User? EventHolder { get; set; }
}