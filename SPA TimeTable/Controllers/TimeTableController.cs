using Microsoft.AspNetCore.Authorization;
using SPA_TimeTable.Models.Entities;

namespace SPA_TimeTable.Controllers;

[Authorize]
public class TimeTableController
{
    private readonly TimeTableContext _timeTableDbContext;
    public TimeTableController(TimeTableContext timeTableDbContext)
    {
        _timeTableDbContext = timeTableDbContext;
    }
    
}