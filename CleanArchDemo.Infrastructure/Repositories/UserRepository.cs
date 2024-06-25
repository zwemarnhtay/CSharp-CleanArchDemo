using CleanArchDemo.Domain.Entities;
using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Infrastructure.Repositories;

public class UserRepository : IRepository<User>
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> GetAll()
    {
        var users = await _dbContext.Users.AsNoTracking()
            .OrderByDescending(x => x.UserId)
            .ToListAsync();
        return users;
    }

    public async  Task<User> GetById(int id)
    {
        var user = await _dbContext.Users.AsNoTracking()
            .FirstOrDefaultAsync(x => x.UserId == x.UserId);
        return user;
    }

    public async Task<int> Add(User user)
    {
        await _dbContext.Users.AddAsync(user);
        var result = _dbContext.SaveChanges();
        return result;
    }
}
