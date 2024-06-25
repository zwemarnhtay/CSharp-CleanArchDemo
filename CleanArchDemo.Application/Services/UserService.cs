using CleanArchDemo.Application.DTOs;
using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Mappings;
using CleanArchDemo.Domain.Entities;
using CleanArchDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Application.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepo;

    public UserService(IRepository<User> userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task<List<UserDTO>> GetAllAsync()
    {
        var users = await _userRepo.GetAll();
        return users.Select(x => x.ToDTO()).ToList();
    }

    public async Task<UserDTO> GetByIdAsync(int id)
    {
        var user = await _userRepo.GetById(id);
        return user.ToDTO();
    }

    public async Task<int> CreateAsync(UserDTO userDTO)
    {
        var result = await _userRepo.Add(userDTO.ToEntity());
        return result;
    }
}
