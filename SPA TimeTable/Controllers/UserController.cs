using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPA_TimeTable.Models.Entities;

namespace SPA_TimeTable.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly TimeTableContext _timeTableDbContext;
    public UserController(TimeTableContext timeTableDbContext )
    {
        _timeTableDbContext = timeTableDbContext;
    }

    [HttpGet("login")]
    public User Get(string login, string password)
    {
        var user = _timeTableDbContext.TUsers.Find(login);
        if (user is null)
        {
            return null;
        }

        if (user.Pasword == password)
        {
            return _timeTableDbContext.TUsers.Where(x => x.Login == login).Include(x => x.TimeTable).First();
        }

        return null;
    }
}