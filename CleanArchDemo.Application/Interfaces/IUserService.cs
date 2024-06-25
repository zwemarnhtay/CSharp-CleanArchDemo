using CleanArchDemo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Application.Interfaces;

public interface IUserService
{
    Task<List<UserDTO>> GetAllAsync();
    Task<UserDTO> GetByIdAsync(int id);
    Task<int> CreateAsync(UserDTO userDTO);
}
